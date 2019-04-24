using Algorithm;
using System;
using System.Diagnostics;

namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            Recursion recursion = new Recursion();

            Stopwatch sw = new Stopwatch();

            sw.Start();
            int sum = recursion.MaxSum(1,0);
            Console.WriteLine($"The Max Value:{sum},used {sw.Elapsed.TotalMilliseconds} MilliSec by MaxSum()");
            Console.WriteLine($"-----------------------------------------------------------------------------");
            sw.Stop();

            sw.Reset();
            sw.Start();
            int sumV1 = recursion.MaxSumV1(1,0);
            Console.WriteLine($"The Max Value:{sumV1},used {sw.Elapsed.TotalMilliseconds} MilliSec by MaxSumV1");
            Console.WriteLine($"-----------------------------------------------------------------------------");
            sw.Stop();

            sw.Reset();
            sw.Start();
            int sum1 = recursion.MaxSumWithCache();
            Console.WriteLine($"The Max Value:{sum1},used {sw.Elapsed.TotalMilliseconds} MilliSec by MaxSumWithCache");
            sw.Stop();
            

            Process curProcess = Process.GetCurrentProcess();
            string cpu = ((Double)(curProcess.TotalProcessorTime.TotalMilliseconds -
                curProcess.UserProcessorTime.TotalMilliseconds)).ToString();
            string memory = (curProcess.WorkingSet64 / 1024 / 1024).ToString() + 
                "M (" + (curProcess.WorkingSet64 / 1024).ToString() + "KB)";

            Console.WriteLine($"Process ID:{curProcess.Id.ToString()} CPU:{cpu} Memory:{memory}");

            

            Console.ReadKey();
        }
    }
}
