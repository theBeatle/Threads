using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threads_basics_console_3
{
    class Program
    {
        static void Main(string[] args)
        {
            ParameterizedThreadStart ts = new ParameterizedThreadStart(Method);
            Thread t1 = new Thread(ts);
            Thread t2 = new Thread(ts);


            t1.Priority = ThreadPriority.AboveNormal;
            t2.Priority = ThreadPriority.BelowNormal;

            t2.Start((object)"\t\t\t2");
            t1.Start((object)"t1");

            Console.ReadKey();
        }
        static void Method(object str)
        {
            string text = (string)str;
            for (int i = 0; i < 150; i++)
            {
                Console.WriteLine("{0} #{1}", text, i.ToString());
            }
        }
    }
}
