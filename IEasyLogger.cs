namespace EasyLogger
{
    public interface IEasyLogger
    {
        void Log(string message, LogType logType = LogType.Info);
    }
}