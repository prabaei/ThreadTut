using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadTut
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main thread Id" + Thread.CurrentThread.ManagedThreadId);
            for (int i = 0; i < 8; i++)
            {
                Thread test = new Thread(demoApplication);
                test.Start();
            }
        }
        public static void demoApplication()
        {
            while(true)
            Console.WriteLine("test thread Id" + Thread.CurrentThread.ManagedThreadId);
        }
    }
}
