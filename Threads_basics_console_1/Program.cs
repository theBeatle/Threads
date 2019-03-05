using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threads_basics_console_1
{
    class Program
    {
        static void Main(string[] args)
        {

             ThreadStart threadstart = Method;
         //   Thread thread = new Thread (threadstart);
            Thread thread = new Thread(Method);
            thread.Start(); 
                        


            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine($"{i} Hello in main");
            }
            //Method();
            Console.ReadKey();
        }

        static void Method()
        {
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(100);
                Console.WriteLine($"\t\t\t {i} Hello in thread");
                //Console.Beep();
            }
        }
    }
}
