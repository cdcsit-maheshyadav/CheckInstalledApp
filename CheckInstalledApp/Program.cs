using System;

namespace CheckInstalledApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the name of application.");
            var appName=Console.Read().ToString();
            var app = InstalledApp.IsAppInstalled(appName);

            Console.WriteLine(app);
            Console.Read();
        }
    }
}
