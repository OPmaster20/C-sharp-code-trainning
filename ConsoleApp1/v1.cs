using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace v1
{
    public class Year()
    {
        public int date = 0;

        public bool If()
        {
            if (DateTime.IsLeapYear(date))
            {
                Console.WriteLine("Yes");
                return true;
            }
            Console.WriteLine("No");
            return false;
        }
    }

    public class Ins()
    {
        public static void Run()
        {
            try
            {
                Year year = new Year();
                year.date = Convert.ToInt32(Console.ReadLine());
                year.If();
            }
            catch (Exception e)
            {
                Console.Write(e.ToString());
            }
            
        }
        

    }
}
