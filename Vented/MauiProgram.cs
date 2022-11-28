using Microsoft.Extensions.Logging;
using Vented.Page;
using Vented.ViewModel;

namespace Vented;

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
			});

#if DEBUG
        builder.Logging.AddDebug();
#endif
		//Pages
        builder.Services.AddSingleton<LoginPage>();
		//ViewModel
        builder.Services.AddSingleton<LoginViewModel>();


        return builder.Build();
	}
}
