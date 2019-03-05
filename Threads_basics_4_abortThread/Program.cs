using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threads_basics_4_abortThread
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreadStart ts = new ThreadStart(Method);
            Thread t = new Thread(ts);
            t.Start();
            Console.WriteLine("Press any button to abort Thread");
            Console.ReadKey();
            t.Abort(); //force END thread
            Console.WriteLine("Press any button to abort Thread");
            Console.ReadKey();
        }
        static void Method()
        {
            try
            {
                for (int i = 0; i < 100; i++)
                {
                    Thread.Sleep(100);
                    Console.WriteLine(i.ToString());
                }
            }
            finally
            {
                Console.WriteLine("End Thread Work");
            }
        }
    }
}
