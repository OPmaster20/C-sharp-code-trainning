using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreatingAndUsingObjects;

namespace v8
{

    public class Ins()
    {
        public static void Run()
        {
            
            Cat[] cat = new Cat[10];
            for (int i = 0; i < 10; i++)
            {
                cat[i] = new Cat();
            }

            Sequence sequence = new Sequence();
            for (int j = 0; j < 10; j++)
            {
                Console.Write("cat" + j.ToString());
                sequence.Call_SayMiau(cat[j]);
            }
            
        }


    }
}
