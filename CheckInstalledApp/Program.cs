using System;

namespace CheckInstalledApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the name of application.");
            var appName=Console.Read().ToString();
            var isInstalled = InstalledApp.IsAppInstalled(appName);

            Console.WriteLine(isInstalled ? "The application is installed." : "The application is not installed.");
            Console.ReadKey();
        }
    }
}
