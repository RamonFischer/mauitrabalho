using LiteDB;
using Projeto_Curso.Configurations;
using Projeto_Curso.Repositories;
using Projeto_Curso.Views;

namespace Projeto_Curso;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			}).RegisterDatabase()
			.RegisterViews();

		return builder.Build();
	}

    public static MauiAppBuilder RegisterDatabase(this MauiAppBuilder mauiAppBuilder)
    {
        mauiAppBuilder.Services.AddSingleton<LiteDatabase>(
        configurations => {
			return new LiteDatabase($"Filename={appConfigs.databasePath};Connection;Connection=Shared");
        }
        );
        mauiAppBuilder.Services.AddTransient<ITransactionRepository, TransactionRepository>();
        return mauiAppBuilder;
    }

    public static MauiAppBuilder RegisterViews(this MauiAppBuilder mauiAppBuilder)
    { 
        mauiAppBuilder.Services.AddTransient<TransactionAdd>();
        mauiAppBuilder.Services.AddTransient<TransactionList>();
        mauiAppBuilder.Services.AddTransient<TransactionEdit>();
        mauiAppBuilder.Services.AddTransient<TransactionGet>();
        return mauiAppBuilder;
    }

}



