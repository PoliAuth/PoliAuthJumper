using System.Diagnostics;
using System.IO;
using System;

namespace PoliAuth_Jumper
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string pathDir = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
                pathDir = Path.Combine(pathDir, "poliauth\\");
                var pathFile = Path.Combine(pathDir + "PoliAuthenticator.exe");
                if (!File.Exists(pathFile))
                    throw new Exception("File PoliAuthenticator.exe is not present in directory " + pathDir
                        + " execution cannot be completed. Have you installed the application properly?");
                ProcessStartInfo info = new ProcessStartInfo(pathFile);
                info.WorkingDirectory = pathDir;
                info.UseShellExecute = false;
                info.Arguments = "-deeplink";
                info.LoadUserProfile = true;
                Process.Start(info);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Console.ReadKey();
            }
        }
    }
}

