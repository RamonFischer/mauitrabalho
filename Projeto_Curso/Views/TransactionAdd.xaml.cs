using Projeto_Curso.Models;
using Projeto_Curso.Repositories;
using System.Text;

namespace Projeto_Curso.Views;

public partial class TransactionAdd : ContentPage
{
    ITransactionRepository _transactionRepository;

    public TransactionAdd(ITransactionRepository transactionRepository)
    {
        _transactionRepository = transactionRepository;
        InitializeComponent();
    }

    public void OnButton_Save_TransactionAdd(object sender, EventArgs e)
    {
        if (validate() == false) return;

        saveData();
    }


   private void saveData()
    {
        Transaction transaction = new Transaction()
        {
            Type = RadioIncome.IsChecked ? TransactionType.Expenses : TransactionType.Profit,
            Name = EntryNome.Text,
            Value = double.Parse(EntryValor.Text),
            Date = DatePickerDate.Date
        };

        _transactionRepository.Add(transaction);

        App.Current.MainPage.DisplayAlert("Sucesso!", "Salvo no banco de dados!", "OK");
    }

    private bool validate()
    {
        {

            bool valid = true;
            StringBuilder sb = new StringBuilder();

            if (string.IsNullOrEmpty(EntryNome.Text) || string.IsNullOrWhiteSpace(EntryNome.Text))
            {
                sb.AppendLine("O campo 'Nome' deve ser preenchido!");
                valid = false;
            }
            if (string.IsNullOrEmpty(EntryValor.Text) || string.IsNullOrWhiteSpace(EntryValor.Text))
            {
                sb.AppendLine("O campo 'Valor' deve ser preenchido!");
                valid = false;
            }
            double result;
            if (!string.IsNullOrEmpty(EntryValor.Text) && !double.TryParse(EntryValor.Text, out result))
            {
                sb.AppendLine("O campo 'Valor' inválido!");
                valid = false;
            }
            if (valid == false)
            {
                Error.Text = sb.ToString();
                Error.IsVisible = true;
            }
            return valid;
        }
    }
}

