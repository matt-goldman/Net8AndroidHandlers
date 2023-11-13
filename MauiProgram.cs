using Microsoft.Extensions.Logging;
using Microsoft.Maui.Platform;

namespace Net8AndroidHandlers
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
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });
#if ANDROID
            Microsoft.Maui.Handlers.EntryHandler.Mapper.AppendToMapping("TestEntry", (handler, view) =>
            {
                handler.PlatformView.Background = null;
                handler.PlatformView.SetBackgroundColor(Android.Graphics.Color.Pink);      
                handler.PlatformView.SetTextColor(Android.Graphics.Color.Aqua);
            });

            Microsoft.Maui.Handlers.LabelHandler.Mapper.AppendToMapping("TestLabel", (handler, view) =>
            {
                handler.PlatformView.Background = null;
                handler.PlatformView.SetBackgroundColor(Android.Graphics.Color.Violet);      
                handler.PlatformView.SetTextColor(Android.Graphics.Color.Beige);
            });

            Microsoft.Maui.Handlers.ButtonHandler.Mapper.AppendToMapping("TestButton", (handler, view) =>
            {
                handler.PlatformView.Background = null;
                handler.PlatformView.SetBackgroundColor(Android.Graphics.Color.Yellow);      
                handler.PlatformView.SetTextColor(Android.Graphics.Color.Green);
                handler.PlatformView.SetAllCaps(true);
                handler.PlatformView.UpdateStrokeThickness(view);
            });
#endif
#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
