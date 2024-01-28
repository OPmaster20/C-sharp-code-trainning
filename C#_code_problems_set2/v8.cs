using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using static System.Math;

namespace HelloWorld
{
	public class Program
	{
		public static void Main(string[] args)
		{
		  int n = Convert.ToInt32(Console.ReadLine());
		  
		  switch(n){
		    case 0:
		    int x = Convert.ToInt32(Console.ReadLine());
		    Console.WriteLine(x+1);
		    break;
		    
		    case 1:
		    double y = Convert.ToDouble(Console.ReadLine());
		    Console.WriteLine(y+1);
		    break;
		    
		    case 2:
		    string z = Console.ReadLine();
		    Console.WriteLine("'{0}*'",z);
		    break;
		    
		  }
		  
		  
		}
	}
}