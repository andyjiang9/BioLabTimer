namespace BioLabTimer;

using CommunityToolkit.Maui;

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
			});


#if WINDOWS
		builder.Services.AddTransient<IFolderPicker, BioLabTimer.Platforms.Windows.FolderPicker>();
#endif
        builder.Services.AddTransient<MainPage>();
        builder.Services.AddTransient<App>();


        return builder.Build();
	}
}
