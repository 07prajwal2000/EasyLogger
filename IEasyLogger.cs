namespace EasyLogger
{
    public interface IEasyLogger
    {
        /// <summary>
        /// Logs the message
        /// </summary>
        /// <param name="message">The Message</param>
        /// <param name="logType">Type of the Log</param>
        void Log(string message, LogType logType = LogType.Info);
    }
}