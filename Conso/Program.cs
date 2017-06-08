using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Conso
{
    class Program
    {
        public static int count = 0;
        static void Main(string[] args)
        {
            var ttv = new Thread(countth);
            var ttv1 = new Thread(countth);

            ttv.Start();
            Thread.Sleep(500);
            ttv1.Start();
        }

        static void countth()
        {
            while (true)
            {
                count++;
                Console.WriteLine("Thread " + Thread.CurrentThread.ManagedThreadId + " count " + count);
                Thread.Sleep(1000);
            }
        }
    }
}
