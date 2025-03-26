using System;
using System.Diagnostics;
using System.Net.NetworkInformation;
using System.Threading;

namespace Chronos
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Stopwatch crono1 = new Stopwatch();
            Stopwatch crono2 = new Stopwatch();

            crono1.Start();
            Thread.Sleep(500);
            crono2.Start();
            Thread.Sleep(250);
            crono1.Stop();
            crono2.Stop();

            TimeSpan ts1 = crono1.Elapsed;
            TimeSpan ts2 = crono2.Elapsed;

            string elpasedTimeCrono1 = String.Format("{0:0}.{1:00}{2:00}", ts1.Seconds, ts1.Milliseconds / 10, ts1.Microseconds / 100);
            string elpasedTimeCrono2 = String.Format("{0:0}.{1:00}{2:00}", ts2.Seconds, ts2.Milliseconds / 10, ts2.Microseconds / 100);

            System.Console.WriteLine($"{elpasedTimeCrono1}, {elpasedTimeCrono2} ");


        }
    }
}
