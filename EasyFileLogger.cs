using System.IO;

namespace EasyLogger
{
    public class EasyFileLogger : IEasyLogger
    {
        private readonly FileInfo _fileInfo;
        private readonly Logging _logging;

        public EasyFileLogger(FileInfo fileInfo)
        {
            _fileInfo = fileInfo;
            _logging = new Logging(_fileInfo);
        }

        public EasyFileLogger(string filePath)
        {
            _fileInfo = new FileInfo(filePath);
            _logging = new Logging(_fileInfo);
        }

        public void Log(string message, LogType logType = LogType.Info)
        {
            switch (logType)
            {
                case LogType.Debug:
                    _logging.LogDebug(message);
                    break;
            
                case LogType.Info:
                    _logging.LogInfo(message);
                    break;
            
                case LogType.Warning:
                    _logging.LogWarning(message);
                    break;
            
                case LogType.Error:
                    _logging.LogError(message);
                    break;
            
                default:
                    _logging.LogDebug(message);
                    break;
            }
        }
    }
}