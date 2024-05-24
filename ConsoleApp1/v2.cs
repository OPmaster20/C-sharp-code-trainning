using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
namespace v2
{
    public class Number()
    {
        public int times = 0;

        public void genrate()
        {
            Random random = new Random();
            for (int i = 0; i < times; i++)
            {
                Console.WriteLine(random.Next(100,200));
            }
        }
    }

    public class Ins()
    {
        public static void Run()
        {
            Number number = new Number();
            number.times = Convert.ToInt32(Console.ReadLine()); 
            number.genrate();
        }
    }
    
    

}

