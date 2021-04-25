using System;

namespace Producer
{
    class Program
    {
        static void Main(string[] args)
        {
            var report = new Report(@"C:\Users\User\Desktop\LogFile.txt");
            Console.WriteLine($"Report Id: {report.Id}, Log size: {report.LogFile.Length}");
        }
    }
}