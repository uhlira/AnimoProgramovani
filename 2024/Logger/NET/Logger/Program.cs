using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace Logger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LoggerService logger = new LoggerService(new List<LoggerComponent>
            {
                new FileLoggerComponent(Path.Combine(Directory.GetCurrentDirectory(), "Log")),
                new SystemLoggerComponent(),
                new ConsoleLoggerComponent()
            });

            try
            {
                logger.Log(new InfoLog("Hello World"));
                logger.Log(new WarningLog("Hello World"));
                logger.Log(new ErrorLog(new Exception("Hello World")));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }

    public class LoggerService
    {
        List<LoggerComponent> Components { get; } = new List<LoggerComponent>();

        public LoggerService(List<LoggerComponent> components) 
        {
            this.Components = components;
        }

        public void Log(Log log)
        {
            foreach (LoggerComponent component in Components)
            {
                component.Log(log);
            }
        }
    }

    public abstract class LoggerComponent
    {
        public abstract void Log(Log log);
    }
    public class FileLoggerComponent : LoggerComponent
    {
        public string Folder { get; set; } = string.Empty;

        public FileLoggerComponent(string folder) 
        {
            this.Folder = folder;
        }

        public override void Log(Log log)
        {
            if (Directory.Exists(Folder))
                this.Folder = Folder;
            else
                Directory.CreateDirectory(Folder);

            File.AppendAllLines(Path.Combine(Folder, DateTime.Now.ToString("yyMMdd")) + ".txt", new List<string>() { log.ToString() });
        }
    }
    public class SystemLoggerComponent : LoggerComponent
    {
        public override void Log(Log log)
        {
            using (EventLog eventLog = new EventLog("Application"))
            {
                EventLogEntryType type = EventLogEntryType.Information;
                switch (log) 
                {
                    case InfoLog info: 
                        type = EventLogEntryType.Information;
                        break;

                    case WarningLog info:
                        type = EventLogEntryType.Warning;
                        break;

                    case ErrorLog info:
                        type = EventLogEntryType.Error;
                        break;

                    default:
                        break;
                }

                eventLog.Source = "Application";
                eventLog.WriteEntry(log.ToString(), type, 101, 1);
            }
        }
    }
    public class ConsoleLoggerComponent : LoggerComponent
    {
        public override void Log(Log log)
        {
            Console.WriteLine(log.ToString());
        }
    }

    public abstract class Log
    {
        public override string ToString()
        {
            return DateTime.Now.ToShortTimeString();
        }
    }
    public class InfoLog : Log
    {
        string Info { get; } = string.Empty;

        public InfoLog(string info)
        {
            this.Info = info;
        }

        public override string ToString()
        {
            return base.ToString() + "   " + "INFO".PadRight(10, ' ') + "   " + Info;
        }
    }
    public class WarningLog : Log
    {
        string Warning { get; } = string.Empty;

        public WarningLog(string warning)
        {
            this.Warning = warning;
        }

        public override string ToString()
        {
            return base.ToString() + "   " + "WARNING".PadRight(10, ' ') + "   " + Warning;
        }
    }
    public class ErrorLog : Log
    {
        Exception Exception { get; }

        public ErrorLog(Exception e) 
        {
            this.Exception = e;
        }
        public override string ToString()
        {
            return base.ToString() + "   " + "ERROR".PadRight(10, ' ') + "   " + Exception.Message;
        }
    }
}

