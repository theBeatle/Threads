using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threads_basics_console_2
{
    class Program
    {
        static void Main(string[] args)
        {
            ParameterizedThreadStart threadstart = new ParameterizedThreadStart(ThreadFunk);


            Thread thread1 = new Thread(threadstart);
            thread1.Start((object)"One");

            

            Thread thread2 = new Thread(threadstart);
            thread2.Start((object)"\t\tTwo");

            ThreadFunk((object)"Main");

        }

        static void ThreadFunk(object a)
        {
            // Get string feom parameter
            string ID = (string)a;
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(ID);
            }
        }
    }
}
