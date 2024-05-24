using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace v11
{
    public class RandomMessage()
    {
        public string[] Laudatory = {" The product is excellent","This is a great product ",
        " I use this product constantly "," This is the best product from this category "};
        public string[] Laudatory2 = {" Now i feel bette "," I managed to change "," It made some miracle "," I can not believe ",
        " You should try it too "};
        public string[] firstname = { " Dayan ", " Stella ", " Hellen ", " Kate " };
        public string[] lastname = { " Johnson ", " Peterson ", " Charls " };
        public string[] cities = { " London ", " Paris ", " Berlin ", " Newyork ", " Madrid " };

        public void Print()
        {
            Random random = new Random();

            Console.WriteLine(Laudatory[random.Next(0, Laudatory.Length)] + Laudatory2[random.Next(0, Laudatory2.Length)] + firstname[random.Next(0, firstname.Length)] +
                lastname[random.Next(0, lastname.Length)] + cities[random.Next(0, cities.Length)]);
        }
    }
    public class Ins()
    {
        public static void Run()
        {
           RandomMessage randomMessage = new RandomMessage();
            randomMessage.Print();

        }


    }
}
