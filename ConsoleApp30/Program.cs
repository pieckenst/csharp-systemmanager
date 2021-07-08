using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Diagnostics;
using Gtk;

namespace ConsoleApp30
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "System Manager";
            Gtk.Application.Init();
            GtkWindo();
            WelcomeLine();
            Console.WriteLine("--------------------------------------------");
            ShowEnvironmentDetails();
            Console.WriteLine("--------------------------------------------");
            var ansys = Console.ReadKey();
            string strCmdText;
            strCmdText = "/c taskkill /f /im explorer.exe";
            
            
            Thread.Sleep(1500);
            if (ansys.KeyChar == 'y')
            {
                ShutDownproc(strCmdText);
            }
            if (ansys.KeyChar == 'r')
            {
                Restartproc(strCmdText);
            }
            if (ansys.KeyChar == 'l')
            {
                LogOutproc(strCmdText);
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Made for sake of passing time on college session in c#  - made in 2021");
                Console.WriteLine("Have a good day");

            }
            Thread.Sleep(1200);
        }

        static void WelcomeLine() {
            DateTime today = DateTime.Today;
            DateTime time = DateTime.Now;
            Console.WriteLine("System management");
            Console.WriteLine("y - for shutdown , r - for restart - l - for logout - other letter close");
            Console.WriteLine("The current time is {0} {1}", today.ToString("dd.MM.yyyy"), time.ToString("HH:mm"));
        }

        static void GtkWindo() {
            MessageDialog mwelco = new MessageDialog(null, DialogFlags.DestroyWithParent, MessageType.Warning, ButtonsType.Ok, "Welcome to c# \n ©Mogilev State Polytechnic College. © Andrey Savich - 2021");
            mwelco.Title = "System Manager";
            //MessageDialog mwelccop = new MessageDialog(null, DialogFlags.DestroyWithParent, MessageType.Warning, ButtonsType.Ok, "©Mogilev State Polytechnic College. © Andrey Savich - 2021");
            //mwelccop.Title = "Copyright";
            mwelco.Run();
            if ((ResponseType)mwelco.Run() == ResponseType.Close)
            {
                mwelco.Destroy();
            }
        }

        static void ShowEnvironmentDetails()
        {
            // Вывести информацию о дисковых устройствах
            // данной машины и другие интересные детали,
            foreach (string drive in Environment.GetLogicalDrives())
                Console.WriteLine("Drive: {0}", drive);
            // Логические устройства
            Console.WriteLine("OS: {0}", Environment.OSVersion); // Версия
                                                                 // операционной системы
            Console.WriteLine("Path to system directory: {0}", Environment.SystemDirectory);
            Console.WriteLine("Number of CPU cores: {0}",
            Environment.ProcessorCount);

            // Количество процессоров
            Console.WriteLine(".NET Version: {0}",
            Environment.Version);
            // Версия платформы .NET
        }

        static void LogOutproc(string strCmdText) {
            MessageDialog mdlogout = new MessageDialog(null, DialogFlags.DestroyWithParent, MessageType.Warning, ButtonsType.Ok, "Logging you out");
            mdlogout.Title = "Preparing to log off";
            Console.WriteLine();
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("[system] killing explorer.exe");
            Console.WriteLine("--------------------------------------------");
            Process.Start("cmd.exe", strCmdText);
            Console.WriteLine();
            Console.WriteLine("Made for sake of passing time on college session in c#  - made in 2021");
            mdlogout.Run();
            if ((ResponseType)mdlogout.Run() == ResponseType.Close)
            {
                mdlogout.Destroy();
            }
            Process.Start("shutdown", "/l /f");
        }

        static void ShutDownproc(string strCmdText) {
            MessageDialog md = new MessageDialog(null, DialogFlags.DestroyWithParent, MessageType.Warning, ButtonsType.Ok, "Proceeding to shutdown or restart");

            md.Title = "Warning";
            Console.WriteLine();
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("[system] killing explorer.exe");
            Console.WriteLine("--------------------------------------------");
            Process.Start("cmd.exe", strCmdText);
            md.Run();
            if ((ResponseType)md.Run() == ResponseType.Close)
            {
                md.Destroy();
            }
            Process.Start("shutdown", "/s /t 60 /d P:1:2 /c Done-shutdown-in-60-sec");
            Console.WriteLine();
            Console.WriteLine("Made for sake of passing time on college session in c#  - made in 2021");

        }

        static void Restartproc(string strCmdText)
        {
            MessageDialog md = new MessageDialog(null, DialogFlags.DestroyWithParent, MessageType.Warning, ButtonsType.Ok, "Proceeding to shutdown or restart");

            md.Title = "Warning";
            Console.WriteLine();
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("[system] killing explorer.exe");
            Console.WriteLine("--------------------------------------------");
            Process.Start("cmd.exe", strCmdText);
            md.Run();
            if ((ResponseType)md.Run() == ResponseType.Close)
            {
                md.Destroy();
            }
            Process.Start("shutdown", "/r /t 60 /d P:1:2 /c Done-reboot-in-60-sec");
            Console.WriteLine();
            Console.WriteLine("Made for sake of passing time on college session in c#  - made in 2021");
        }
    }
}
