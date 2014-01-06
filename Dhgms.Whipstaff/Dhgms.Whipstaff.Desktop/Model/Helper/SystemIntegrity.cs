namespace Dhgms.Whipstaff.Model.Helper
{
    using System;
    using System.IO;
    using System.Reflection;
    using System.Windows.Forms;

    using Dhgms.Whipstaff.Model.Excptn;
    using Dhgms.Whipstaff.Model.Excptn.OperatingSystem;
    using Dhgms.Whipstaff.Model.Excptn.Security;
    using Dhgms.Whipstaff.Model.Helper.SecurityCenter;

    using Microsoft.Win32;

    class SystemIntegrity
    {
        public void CheckOk()
        {
            CheckApplicationCompatabilityMode();
            CheckOperatingSystem();
            CheckTerminalServerSession();
            CheckDomain();

            //check security
            new AntiSpyware().CheckOk();
            new AntiVirus().CheckOk();
            new Firewall().CheckOk();

            //check wireless
            CheckWirelessOk();

            CheckNoWritableRemovableDrives();
        }

        /// <summary>
        /// check to ensure the machine is on a domain
        /// </summary>
        private static void CheckDomain()
        {
        }

        /// <summary>
        /// check to make sure the user isn't trying to use the app
        /// while connected via Terminal Server \ Remote Desktop
        /// </summary>
        private static void CheckTerminalServerSession()
        {
            if (SystemInformation.TerminalServerSession)
            {
                throw new TerminalServerSessionNotAllowed();
            }
        }

        /// <summary>
        /// Check to make sure we're not in compatability mode
        /// Just in case someone is trying to get round some of the security
        /// features of later operating systems
        /// </summary>
        /// <returns>
        /// A flag indicating whether the program is in application compatability mode.
        /// </returns>
        private static void CheckApplicationCompatabilityMode()
        {
            var executableLocation = Assembly.GetEntryAssembly().Location;

            if (IsInApplicationCompatabilityModeRegistry(executableLocation, Registry.CurrentUser)
                || IsInApplicationCompatabilityModeRegistry(executableLocation, Registry.LocalMachine))
            {
                throw new ApplicationCompatabilityModeException();
            }
        }

        /// <summary>
        /// make sure the os is at least xp sp3
        /// </summary>
        private static void CheckOperatingSystem()
        {
            const int MinMajor = 5;
            const int MinMinor = 1;
            const int MinRevision = 2600;
            const int MinBuild = 5573;

            if (Environment.OSVersion.Version.Major > MinMajor)
            {
                return;
            }

            if (Environment.OSVersion.Version.Major == MinMajor
                && Environment.OSVersion.Version.Major >= MinMinor
                && Environment.OSVersion.Version.Revision >= MinRevision
                && Environment.OSVersion.Version.Build >= MinBuild)
            {
                return;
            }

            throw new LessThanMinimumVersion("XP SP3", MinMajor, MinMinor, MinRevision, MinBuild);
        }

        private static void CheckWirelessOk()
        {
            //if we detect a wireless connection, the users session is going straight in the bin
        }

        private static void CheckLanOk()
        {
            //make sure not going over VPN
        }

        private static void CheckUserRights()
        {
            //prevent people with admin access on XP
            //or with elevated priv's on vista or later
        }

        private static void CheckNoWritableRemovableDrives()
        {
            DriveInfo[] drives = DriveInfo.GetDrives();

            foreach (DriveInfo drive in drives)
            {
                if (drive.DriveType == DriveType.Removable)
                {
                    throw new ApplicationException();
                }

                //http://www.codeproject.com/KB/miscctrl/imapi2.aspx
            }
        }

        /// <summary>
        /// Checks the registry for application compatability flags belonging to the program
        /// </summary>
        /// <param name="executableLocation">
        /// The executable location.
        /// </param>
        /// <param name="rootRegistryHive">
        /// The root registry hive.
        /// </param>
        /// <returns>
        /// Flag indicating whether the program was found in the registry key
        /// for application compatability
        /// </returns>
        private static bool IsInApplicationCompatabilityModeRegistry(string executableLocation, RegistryKey rootRegistryHive)
        {
            var subKey = rootRegistryHive.OpenSubKey(@"Software\Microsoft\Windows NT\CurrentVersion\AppCompatFlags\Layers", false);

            if (subKey != null)
            {
                // sub key exists
                // so application compabatability has been used for something
                var value = subKey.GetValue(executableLocation);
                if (value != null)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
