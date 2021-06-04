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
            Console.Title =  "System Manager";
            Gtk.Application.Init();
            MessageDialog mwelco = new MessageDialog(null, DialogFlags.DestroyWithParent, MessageType.Warning, ButtonsType.Ok, "Welcome to c# \n ©Mogilev State Polytechnic College. © Andrey Savich - 2021");
            mwelco.Title = "System Manager";
            //MessageDialog mwelccop = new MessageDialog(null, DialogFlags.DestroyWithParent, MessageType.Warning, ButtonsType.Ok, "©Mogilev State Polytechnic College. © Andrey Savich - 2021");
            //mwelccop.Title = "Copyright";
            mwelco.Run();
            Console.WriteLine("System management");
            Console.WriteLine("y - for shutdown , r - for restart - l - for logout - other letter close");
            Console.WriteLine("--------------------------------------------");
            var ansys = Console.ReadKey();
            string strCmdText;
            strCmdText = "/c taskkill /f /im explorer.exe";
            MessageDialog md = new MessageDialog(null, DialogFlags.DestroyWithParent, MessageType.Warning, ButtonsType.Ok, "Proceeding to shutdown or restart");
            MessageDialog mdlogout = new MessageDialog(null, DialogFlags.DestroyWithParent, MessageType.Warning, ButtonsType.Ok, "Logging you out");
            md.Title = "Warning";
            mdlogout.Title = "Preparing to log off";
            Thread.Sleep(1500);
            if (ansys.KeyChar == 'y' )
            {
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
            if (ansys.KeyChar == 'r')
            {
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
            if (ansys.KeyChar == 'l')
            {
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
            else
            {
                Console.WriteLine();
                Console.WriteLine("Made for sake of passing time on college session in c#  - made in 2021");
                Console.WriteLine("Have a good day");
                
            }
            Thread.Sleep(1200);
        }
    }
}
