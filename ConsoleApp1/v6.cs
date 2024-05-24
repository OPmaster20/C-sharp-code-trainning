using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace v6
{
    public class Triangle()
    {
        public void Choose(int k)
        {
            if (k == 1)
            {
                Allsides();
            }else if (k == 2)
            {
                Sidesandaltitude();
            }
            else
            {
                Sidesandabgle();
            }
        }
        public void Allsides()
        {
            double sides1 = Convert.ToDouble(Console.ReadLine()); ;
            double sides2 = Convert.ToDouble(Console.ReadLine()); ;
            double sides3 = Convert.ToDouble(Console.ReadLine()); ;
            double p = (sides1 + sides2 + sides3) / 2;
            Console.WriteLine("Result: " + Math.Sqrt(p * (p - sides1) * (p - sides2) * (p - sides3)));
        }

        public void Sidesandaltitude()
        {
            double side = Convert.ToDouble(Console.ReadLine());
            double altitude = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("result: " + (side * altitude) / 2);
        }

        public void Sidesandabgle()
        {
            double sides1 = Convert.ToDouble(Console.ReadLine()); ;
            double sides2 = Convert.ToDouble(Console.ReadLine()); ;
            double angle = Convert.ToDouble(Console.ReadLine());

            double radians = angle * Math.PI / 180;
            double sine = Math.Sin(radians);

            Console.WriteLine("result: " + (sides1 * sides2 * sine) / 2);
        }
    }

    public class Ins()
    {
        public static void Run()
        {
            Triangle triangle = new Triangle();
            int n = Convert.ToInt32(Console.ReadLine());
            triangle.Choose(n);
        }


    }
}
