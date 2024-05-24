using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace v5
{
    public class Triangle()
    {
        public double sides1 = 0;
        public double sides2 = 0;
        public void Hypotenuse()
        {
            Console.WriteLine(">>" +  Math.Sqrt((sides1 * sides1) + (sides2 * sides2)));
        }
    }

    public class Ins()
    {
        public static void Run()
        {
            Triangle triangle = new Triangle();
            triangle.sides1 = Convert.ToDouble(Console.ReadLine());
            triangle.sides2 = Convert.ToDouble(Console.ReadLine());
            triangle.Hypotenuse();
        }


    }
}
