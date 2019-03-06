using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ThreadTimer2
{
    class Program
    {
        static int Sek = 10;

        static void Main(string[] args)
        {
            TimerCallback timercallback = new TimerCallback(TimerTick);
            Timer timer = new Timer(timercallback);
            timer.Change(1000, 1000); // Запуск таймера.
            Console.ReadKey();
        }

        static void TimerTick(object obj)
        {

            Console.WriteLine($"{--Sek}");
            if (Sek <= 0)
            {
                Timer a = (Timer)obj;
                a.Dispose(); // timer Stop 
                Console.WriteLine("kaboom!!!");
            }

        }
    }
}
