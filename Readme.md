#Easy Logger made Logging easy.

## Log to files as well as to consoles.

#### This Project was made with my free time and will be released when i make changes to this project.
## For ASP.NET and Microsoft's Dependency Injection service Middleware will be released soon.

###Initialize the IEasyLogger interface with the FileLogger Instance.
```c#
IEasyLogger easyLogger = new EasyFileLogger(Path.Combine(Environment.CurrentDirectory, "log.txt"));

OR using Console Logger

IEasyLogger easyLogger = new EasyConsoleLogger();
```

###then Log with Message

```c#
easyLogger.Log("HELLO WORLD");
```

###or

```c#
/// <summary>
/// Logs the message
/// </summary>
/// <param name="message">The Message</param>
/// <param name="logType">Type of the Log</param>
easyLogger.Log(message: "HELLO WORLD", logType: LogType.Warning);
```
### Four types of Logging can be done
```c#
public enum LogType { Debug, Info, Warning, Error }
```
