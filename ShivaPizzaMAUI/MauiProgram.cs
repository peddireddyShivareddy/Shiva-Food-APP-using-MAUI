using Microsoft.Extensions.Logging;
using ShivaPizzaMAUI.Services;
using ShivaPizzaMAUI.Views;
using ShivaPizzaMAUI.Pages;


namespace ShivaPizzaMAUI
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
            

#if DEBUG
    		builder.Logging.AddDebug();
#endif
            AddItemServices(builder.Services);

            return builder.Build();
        }
        private static IServiceCollection
            AddItemServices(IServiceCollection services)
        {
            services.AddSingleton<ItemService>();
            services.AddSingleton<HomeView>()
                .AddSingleton<HomePage>();
                return services;
        }
    }
}
