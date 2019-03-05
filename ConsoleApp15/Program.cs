using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            TimerCallback timercallback = new TimerCallback(TimerTick);
            Timer timer = new Timer(timercallback);
            timer.Change(2000, 1000); // Запуск таймера. 2000 - час очікування 500 - частота
            //TimerCallback timercallback2 = new TimerCallback(TimerTick);
           // Timer timer1 = new Timer(timercallback);
           // timer1.Change(2000, 100);    


            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("alloha");
                Thread.Sleep(750);
            }
            Console.WriteLine("alloha");
            Console.ReadKey();
        }

        static void TimerTick(object a)
        {
            Console.WriteLine("Hello in timer");
            Console.ReadLine();
        }
    }
}
