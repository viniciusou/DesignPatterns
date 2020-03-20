using System;

namespace NullObject.Logs
{
    public class ConsoleLog : ILog
    {
        public void Info(string message)
        {
            Console.WriteLine(message);
        }

        public void Warn(string message)
        {
            Console.WriteLine($"Warning!!! {message}");
        }
    }
}
