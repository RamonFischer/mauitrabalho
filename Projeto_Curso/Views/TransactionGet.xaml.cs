using LiteDB;
using Projeto_Curso.Repositories;

namespace Projeto_Curso.Views;

public partial class TransactionGet : ContentPage
{
	
    private readonly LiteDatabase _liteDatabase;
    public TransactionGet()
	{
		InitializeComponent();
	}

	public void allllllll ()
	{
        TransactionRepository transactionRepository = new TransactionRepository(_liteDatabase);

    }
}