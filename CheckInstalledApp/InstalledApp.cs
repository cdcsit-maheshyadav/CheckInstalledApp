using System.Linq;
using Microsoft.Win32;

namespace CheckInstalledApp
{
    public class InstalledApp
    {
        /// 08/04/2022 Mahesh Kumar Yadav. <br/>
        /// <summary>
        /// Check app is installed or not
        /// </summary>
        /// <param name="cName">Application name</param>
        /// <returns></returns>
        public static bool IsAppInstalled(string cName)
        {
            string displayName;

            var registryKey = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall";
            var key = Registry.LocalMachine.OpenSubKey(registryKey);
            if (key != null)
            {
                foreach (var subKey in key.GetSubKeyNames().Select(keyName => key.OpenSubKey(keyName)))
                {
                    displayName = subKey?.GetValue("DisplayName") as string;

                    if (displayName != null && displayName.Contains(cName))
                    {
                        return true;
                    }
                }

                key.Close();
            }

            registryKey = @"SOFTWARE\Wow6432Node\Microsoft\Windows\CurrentVersion\Uninstall";
            key = Registry.LocalMachine.OpenSubKey(registryKey);
            if (key == null) return false;
            {
                foreach (var subKey in key.GetSubKeyNames().Select(keyName => key.OpenSubKey(keyName)))
                {
                    displayName = subKey?.GetValue("DisplayName") as string;
                    if (displayName != null && displayName.Contains(cName))
                    {
                        return true;
                    }
                }

                key.Close();
            }
            return false;
        }
    }
}