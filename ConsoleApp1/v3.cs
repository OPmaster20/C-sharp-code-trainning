using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace v3
{
    public class Today()
    {
        public void Print()
        {
            Console.WriteLine(DateTime.Today.DayOfWeek.ToString());
        }
    }

    public class Ins()
    {
        public static void Run()
        {
            Today today = new Today();
            today.Print();
        }


    }
}
