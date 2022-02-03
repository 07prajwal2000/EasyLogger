namespace EasyLogger.Extensions
{
    public class EasyLoggerOptions
    {
        public string FilePath { get; set; }
        public LogOutputType LogOutputType { get; set; } = LogOutputType.Console;
    }
}