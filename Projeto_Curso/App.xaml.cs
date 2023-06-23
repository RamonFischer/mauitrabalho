using Projeto_Curso.Views;
using Projeto_Curso.Repositories;
namespace Projeto_Curso;

public partial class App : Application
{
	public App(TransactionList list)
	{
		InitializeComponent(); 
        MainPage = new NavigationPage(list);
	}
}
