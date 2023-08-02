using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppILogger
{
    internal class ConsoleLogger : ILogger
    {
        public void LogError(string message)
        {
            Console.WriteLine($"LogLevel:Error. {message}");
        }

        public void LogInformation(string message)
        {
            Console.WriteLine($"LogLevel:Information. {message}");
        }

        public void LogWarning(string message)
        {
            Console.WriteLine($"LogLevel:Warning. {message}");
        }
    }
}
