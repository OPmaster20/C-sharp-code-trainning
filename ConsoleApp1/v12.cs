using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace v12
{
    public class Numeral()
    {
        public string expression = "";

        public void Print1()
        {
            string[] ex = expression.Split(" ");

            for (int i = 0; i < ex.Length; i++)
            {
                if (ex[i] == "*")
                {
                    ex[i] = (Convert.ToInt32(ex[i - 1]) * Convert.ToInt32(ex[i + 1])).ToString();
                    ex = ex.Where(x => x != ex[i - 1]).ToArray();
                    ex = ex.Where(x => x != ex[i]).ToArray();
                }
                if (ex[i] == "/")
                {
                    ex[i] = (Convert.ToInt32(ex[i - 1]) / Convert.ToInt32(ex[i + 1])).ToString();
                    ex = ex.Where(x => x != ex[i - 1]).ToArray();
                    ex = ex.Where(x => x != ex[i]).ToArray();
                }
            }
            // 0 1 2
            // 1 2 3
            int sum = 0;
            // 0 + 1 - 2 + 3 4
            for (int i = 0; i < ex.Length - 1; i++)
            {
                if (ex[i].Equals("+"))
                {
                    if (sum != 0)
                    {
                        sum += Convert.ToInt32(ex[i + 1]);
                    }
                    else
                    {
                        sum = Convert.ToInt32(ex[i - 1]) + Convert.ToInt32(ex[i + 1]);
                    }
                    
                    
                   
                }
                else if (ex[i].Equals("-"))
                {
                    if (sum != 0) 
                    {
                        sum -= Convert.ToInt32(ex[i + 1]);
                    }
                    else
                    {
                        sum = Convert.ToInt32(ex[i - 1]) - Convert.ToInt32(ex[i + 1]);
                    }
                    

                }
                

            }

            Console.WriteLine("Sum is " + sum);
        }

    }
    public class Ins()
    {
        
        public static void Run()
        {
            Numeral numeral = new Numeral();
            numeral.expression = "-1 + 2 + 3 * 4 - 1";
            numeral.Print1();
        }


    }

}
