
using Microsoft.Extensions.Logging;

using Demo1.Services.Settings;
using Demo1.Services.Navigation;
using Demo1.ViewModels;
using CommunityToolkit.Maui;

namespace Demo1;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.UseMauiCommunityToolkit()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			})
			.RegisterAppServices()
			.RegisterViewModels()
			.RegisterViews();

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}


	public static MauiAppBuilder RegisterAppServices(this MauiAppBuilder mauiAppBuilder)
	{
		mauiAppBuilder.Services.AddSingleton<ISettingsService, SettingsService>();
		mauiAppBuilder.Services.AddSingleton<INavigationService, DemoNavigationService>();
		return mauiAppBuilder;
	}

	public static MauiAppBuilder RegisterViews(this MauiAppBuilder mauiAppBuilder)
	{
		Console.WriteLine("RegisterViews");
		mauiAppBuilder.Services.AddTransient<MainPage>();
		mauiAppBuilder.Services.AddTransient<CatalogView>();
		return mauiAppBuilder;
	}

	public static MauiAppBuilder RegisterViewModels(this MauiAppBuilder mauiAppBuilder)
	{
		Console.WriteLine("RegisterViewModels");
		mauiAppBuilder.Services.AddSingleton<CatalogViewModel>();
		return mauiAppBuilder;
	}



}

