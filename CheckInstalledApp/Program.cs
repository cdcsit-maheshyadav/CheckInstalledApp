using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
