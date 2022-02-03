using System;
using Microsoft.Extensions.DependencyInjection;

namespace EasyLogger.Extensions
{
    public static class DIExtensions
    {
        public static void AddEasyLogger(this IServiceCollection services, 
            Action<EasyLoggerOptions> ConfigureOptions = null)
        {
            var options = new EasyLoggerOptions();
            ConfigureOptions?.Invoke(options);

            switch (options.LogOutputType)
            {
                case LogOutputType.WriteToFile:
                    services.AddSingleton<IEasyLogger, EasyFileLogger>(e =>
                        new EasyFileLogger(options.FilePath));
                    break;
                
                case LogOutputType.Console:
                    services.AddSingleton<IEasyLogger, EasyConsoleLogger>(e =>
                        new EasyConsoleLogger());
                    break;
            }
        }
    }
}