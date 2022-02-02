using System;
using System.IO;

namespace EasyLogger
{
    internal class Logging
    {
        private readonly FileInfo _fileInfo;
        private readonly LogOutputType _logOutputType;

        internal Logging() { _logOutputType = LogOutputType.Console; }
    
        internal Logging(FileInfo fileInfo)
        {
            _fileInfo = fileInfo;
            _logOutputType = LogOutputType.WriteToFile;
        }
    
        internal void LogInfo(string message)
        {
            Log("INFO", message);
        }
    
        internal void LogWarning(string message) => Log("WARNING", message);

        internal void LogError(string message)
        {
            Log("ERROR", message);
        }
    
        internal void LogDebug(string message) => Log("DEBUG", message);

        private void Log(string identifier, string message)
        {
            switch (_logOutputType)
            {
                case LogOutputType.WriteToFile:
                    LogFile(identifier, message);
                    break;
            
                case LogOutputType.Console:
                    LogConsole(identifier, message);
                    break;
            
                default:
                    LogConsole(identifier, message);
                    break;
            }
        
        }

        private void LogFile(string identifier, string message)
        {
            try
            {
                using (var sw = new StreamWriter(_fileInfo.FullName, true))
                {
                    ReadOnlySpan<char> msg = $"{ identifier }: { DateTime.Now } : { message }".AsSpan();
                    sw.WriteLine(msg.ToArray());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private void LogConsole(string identifier, string message)
        {
            Console.WriteLine($"{ identifier }: { DateTime.Now } : { message }");
        }
    }
}