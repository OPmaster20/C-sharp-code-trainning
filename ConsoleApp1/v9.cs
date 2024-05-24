using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace v9
{
    public class Count_day()
    {
        public int day = 0;
        public string date = string.Empty;
        public string[] holiday = new string[1];

        public void Count()
        {
            
            DateTime d = new DateTime();
            d = DateTime.Parse(date);


            holiday[0] = "2024.5.13";              //public holiday
            DateTime[] dateTimes = new DateTime[1];
            dateTimes[0] = DateTime.Parse(holiday[0]);


            try
            {
                for (DateTime now = DateTime.Now.Date; now < d; now = now.AddDays(1))
                {
                    if (now.DayOfWeek.ToString() != "Saturday" && now.DayOfWeek.ToString() != "Sunday")
                    {
                        foreach (DateTime hoildays in dateTimes)
                        {
                            if (hoildays != now)
                            {
                                day++;
                            }
                        }
                    }
                    
                }
                
                //Console.WriteLine("Day: " + ((d - DateTime.Now.Date).Days - 8));
                Console.WriteLine("Days: " + day);
            }
            catch (Exception) {

                Console.WriteLine("Error !");
     
            }
            

            
            
        }

    }

    public class Ins()
    {
        public static void Run()
        {
            try
            {
                Count_day count_Day = new Count_day();
                count_Day.date = Console.ReadLine();
                count_Day.Count();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
           
        }


    }
}
