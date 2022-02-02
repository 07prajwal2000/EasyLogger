using System;

namespace EasyLogger
{
    public class EasyConsoleLogger : IEasyLogger
    {
        private readonly Logging _logging;
        public EasyConsoleLogger()
        {
            _logging = new Logging();
        }
    
        public void Log(string message, LogType logType = LogType.Info)
        {
            switch (logType)
            {
                case LogType.Debug:
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    _logging.LogDebug(message);
                    Console.ResetColor();
                    break;

                case LogType.Info:
                    Console.ForegroundColor = ConsoleColor.White;
                    _logging.LogInfo(message);
                    Console.ResetColor();
                    break;
            
                case LogType.Warning:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    _logging.LogWarning(message);
                    Console.ResetColor();
                    break;
            
                case LogType.Error:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    _logging.LogError(message);
                    Console.ResetColor();
                    break;
            
                default:
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    _logging.LogDebug(message);
                    Console.ResetColor();
                    break;
            }
        }
    }
}