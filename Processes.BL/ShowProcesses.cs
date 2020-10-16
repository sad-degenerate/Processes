using System;
using System.Diagnostics;
using System.Threading;

namespace Processes.BL
{
    public class ShowProcesses
    {
        public static void Show(int interval)
        {
            while (true)
            {
                foreach (var proc in Process.GetProcesses())
                    Console.WriteLine($"ID: {proc.Id} Name: {proc.ProcessName} Memory: {proc.PagedMemorySize}");

                Console.WriteLine("\n");

                Thread.Sleep(interval);
            }
        }
    }
}