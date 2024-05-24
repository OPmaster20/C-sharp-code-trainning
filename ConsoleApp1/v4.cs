using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace v4
{
    public class Print()
    {
        public void sy()
        {
            long time = Environment.TickCount64;
            Console.WriteLine(time);
            int days = 0;
            int hours = 0;
            int minutes = 0;
            int seconds = 0;
            int n = 0;

            for (long i = 0; i < time; i++,n++)
            {
                if (hours == 24)
                {
                    days++;
                    hours = 1;
                }

                if (seconds == 60)
                {
                    minutes++;
                    seconds = 1;
                }
                
                if (minutes == 60)
                {
                    hours++;
                    minutes = 1;
                }

                if (n == 1000)
                {
                    seconds++;
                    n = 1;
                }
            }

            Console.WriteLine("Days: " + (days) + " hours: " + (hours) + " minutes: " + (minutes) + " seconds: " + (seconds));
        }
    }

    public class Ins()
    {
        public static void Run()
        {
            Print print = new Print();
            print.sy();
        }


    }
}
