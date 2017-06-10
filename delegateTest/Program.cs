using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegateTest
{
    class Program
    {
         delegate void testDelegate();
        static void Main(string[] args)
        {
            testDelegate dell = new testDelegate(foo);
            testDelegate dd = goo;
            dd();
            dell.Invoke();
        }
        static void foo()
        {
            Console.WriteLine("foo()");
        }
        static void goo()
        {
            Console.WriteLine("goo()");
        }
    }
}
