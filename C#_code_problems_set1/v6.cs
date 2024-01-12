using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace HelloWorld
{
	public class Program
	{
	  public static void re(double a,double b,double h){
	    double d = a * b;
	    double p = 2 * (a + b);
	    Console.WriteLine(d + " and " + p);

	  } 
		public static void Main()
		{
		    Console.WriteLine("Input your number: ");
		    
			  double a = double.Parse(Console.ReadLine());
			  double b = double.Parse(Console.ReadLine());
			  double h = double.Parse(Console.ReadLine());
			  re(a,b,h);
		}
	}
}