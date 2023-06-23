using Projeto_Curso.Repositories;

namespace Projeto_Curso.Views;

public partial class TransactionList : ContentPage
{
    TransactionAdd _transactionAdd;
    TransactionEdit _transactionEdit = new TransactionEdit();
    TransactionRepository _transactionRepository;
    public TransactionList(TransactionAdd add, TransactionEdit edit)
	{
        this._transactionAdd = add; 
        this._transactionEdit = edit;
       
        InitializeComponent();
    }

	private void OnButton_Clicked_To_TransactionAdd(object sender, EventArgs e)
	{
		Navigation.PushAsync(_transactionAdd);
	}

    private void OnButton_Clicked_To_TransactionEdit(object sender, EventArgs e)
    {
        Navigation.PushAsync(_transactionEdit);
    }
}