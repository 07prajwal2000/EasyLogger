using System;
using System.IO;

namespace EasyLogger.Extensions
{
    public class EasyLoggerOptions
    {
        public string FilePath { get; set; } = Path.Combine(Environment.CurrentDirectory, "[EASYLOGGER.txt]");
        public LogOutputType LogOutputType { get; set; } = LogOutputType.Console;
    }
}