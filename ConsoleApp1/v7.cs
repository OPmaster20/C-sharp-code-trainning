using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingAndUsingObjects
{
    public class Cat()
    {
        public static void Callback()
        {
            Console.WriteLine("Call cat!");
        }

        public void SayMiau()
        {
            Console.WriteLine("Hahahahahaha");
        }
    }

    public class Sequence() { 
        
        public static void Callback()
        {
            Console.WriteLine("Call seq!");
        }

        public void Call_SayMiau(Cat cat)
        {
            cat.SayMiau();
        }
    }

    public class Ins()
    {
        public static void Run()
        {
            Cat cat = new Cat();
            Sequence seq = new Sequence();
        }


    }
}
