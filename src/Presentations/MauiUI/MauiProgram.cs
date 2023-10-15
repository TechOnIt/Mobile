using Microsoft.Extensions.Logging;

namespace MauiUI
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("Barlow-Regular.ttf", "BarlowRegular");
                    fonts.AddFont("Barlow-ExtraBold.ttf", "BarlowExtraBold");
                });

#if DEBUG
		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}