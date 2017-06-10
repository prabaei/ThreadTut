using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace breakitup
{
    class Program
    {
        public static byte[] values = new byte[500000000];

        static void Main(string[] args)
        {
            generateInitalval();
            Stopwatch watch = new Stopwatch();
            watch.Start();
            long tot = 0;
            for (int i = 0; i < values.Length; i++)
            {
                tot += values[i];
            }
            watch.Stop();
            Console.WriteLine("Java t "+tot);
            Console.WriteLine("time elap" + watch.Elapsed);
        }

        private static void generateInitalval()
        {
            Random ran = new Random(548);

            for (int i = 0; i < values.Length; i++)
            {
                 values[i]=(byte)ran.Next(10);
            }
        }
    }
}
