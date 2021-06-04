using System;
using System.Threading;
using System.Diagnostics;


namespace ConsoleApp30
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Welcome to c#");
            Console.WriteLine("MGPK 2021!");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Now we shall shutdown your pc because we wanna");
            Console.WriteLine("--------------------------------------------");
            Thread.Sleep(1500);
            Process.Start("shutdown", "/s /t 60 /d P:1:2 /c Done in c sharp shut down incoming");
            Console.WriteLine("Made for sake of passing time on college session in c# - copyright is none - made in 2021");
            Thread.Sleep(200);
        }
    }
}
