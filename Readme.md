<h1>Easy Logger made Logging easy.</h1>

<h2>Log to files as well as to consoles.</h2>

<h4>This Project was made with my free time and will be released when i make changes to this project.</h4>
<h6>For ASP.NET and Microsoft's Dependency Injection service Middleware will be released soon.</h6>

###Initialize the IEasyLogger interface with the FileLogger Instance.


```c#
IEasyLogger easyLogger = new EasyFileLogger(Path.Combine(Environment.CurrentDirectory, "log.txt"));

OR using Console Logger

IEasyLogger easyLogger = new EasyConsoleLogger();
```

<h4>then Log with Message</h4>

```c#
/// <summary>
/// Logs the message
/// </summary>
/// <param name="message">The Message</param>
easyLogger.Log("HELLO WORLD");
```

or

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

```c#
_easyLogger.Log("Log Message => INFO", LogType.Info);
_easyLogger.Log("Log Message => DEBUG", LogType.Debug);
_easyLogger.Log("Log Message => WARNING", LogType.Warning);
_easyLogger.Log("Log Message => ERROR", LogType.Error);
```
<h3>Console Screenshot of Logs</h3>
<img width="454" height="81" src="./Images/LogScreenshot.png">