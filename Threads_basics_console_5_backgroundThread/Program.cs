using System;
using System.Threading;

namespace Threads_basics_console_5_backgroundThread
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreadStart ts = new ThreadStart(Method);
            Thread t = new Thread(ts);

            // Делаем поток фоновым.
            t.IsBackground = true;
            t.Start();

            Console.WriteLine("\nPress any button to end App");
            Console.ReadKey();
        }

        static void Method()
        {
            for (int i = 10; i >= 0; i--)
            {
                Thread.Sleep(1000);
                Console.Write(i.ToString() + " ");
            }
            Console.WriteLine("\nBackground thread finished");
        }
    }
}
