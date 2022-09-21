using Kantine.Services;
using Kantine.ViewModel;
using Kantine.Views;

namespace Kantine;

public static class MauiProgram
{
	public static void Configure(PrismAppBuilder builder)
	{
		builder


		.ConfigureModuleCatalog(OnConfigureModuleCatalog)
		.RegisterTypes(OnRegisterTypes);
	}
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder()
			.UseMauiApp<App>()
			.UsePrism(Configure)
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
				fonts.AddFont("OpenSans-Bold.ttf", "OpenSansBold");
				fonts.AddFont("Sitka.ttc", "Sitka");
			});

		builder.Services.AddSingleton<VMService>();
		builder.Services.AddSingleton<CandyService>();

		builder.Services.AddSingleton<MenuViewModel>();
		builder.Services.AddTransient<VMDetailsViewModel>();
		builder.Services.AddTransient<CandyDetailsViewModel>();

		builder.Services.AddSingleton<MainPage>();
		builder.Services.AddSingleton<Menu>();

		builder.Services.AddTransient<PopupPageVM>();
		builder.Services.AddTransient<PopupPageCandy>();

		return builder.Build();
	}

	private static void OnConfigureModuleCatalog(IModuleCatalog moduleCatalog)
	{

	}

	private static void OnRegisterTypes(IContainerRegistry containerRegistry)
	{
		// Navigation
		containerRegistry
			.RegisterForNavigation<MainPage>()
			.RegisterForNavigation<Menu, MenuViewModel>()
			.RegisterForNavigation<PopupPageCandy>()
			.RegisterForNavigation<PopupPageVM>()
			.RegisterForNavigation<Profil>()
			.RegisterForNavigation<PaymentPage, CreditCardPageViewModel>()
			.RegisterInstance(SemanticScreenReader.Default);
	}
}
