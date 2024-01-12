using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace HelloWorld
{
	public class Program
	{
	  public static void re(double a){
	    double g = 9.81;
	    double p = (a / g) * 1.7;
	    Console.WriteLine(" output: " + p);

	  } 
		public static void Main()
		{
		    Console.WriteLine("Input: ");
		    
			  double a = double.Parse(Console.ReadLine());
			  re(a);
		}
	}
}