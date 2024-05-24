using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace v10
{
    public class Number()
    {
        public string number = "";

        public void Sum()
        {
            double sum = 0;
            try
            {
                foreach (string item in number.Split(' '))
                {
                    double n = Convert.ToDouble(item);
                    sum += n;
                }

                Console.WriteLine(sum);
            }
            catch (Exception)
            {

                Console.WriteLine("Error");
            }
            
        }
    }
    public class Ins()
    {
        public static void Run()
        {
            try
            {
                Number number = new Number();
                number.number = Console.ReadLine();
                number.Sum();

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
           

        }


    }
}
