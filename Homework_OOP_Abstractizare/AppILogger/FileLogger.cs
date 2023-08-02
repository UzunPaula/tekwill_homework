using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppILogger
{
    internal class FileLogger : ILogger 
    {
        private const string filePath = @"D:\\Curs .NET si C#\\Tekwill_Homework\\Homework_OOP_Abstractizare\\AppILogger\\bin\\Debug\\logs.txt";
        public void LogError(string message)
        {
            Log($"LogLevel: Error. {message}");
        }

        public void LogInformation(string message)
        {
            Log($"LogInformation: Information. {message}");
        }

        public void LogWarning(string message)
        {
            Log($"LogWarning: Warning. {message}");
        }
        private void Log(string message)
        {
            using (var streamWriter = new StreamWriter(filePath, true))
            {
                streamWriter.WriteLine(message);
            }
        }
    }
}
