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
		  int a = 3;
		  int b = 2;
		  int c = 1;
		  
		  int d = (b*b) - (4 * a * c);
		  if(d == 0){
		    double g = (-1 * b) / (2 * a);
		    Console.WriteLine("X1,2 is {0}",g);
		  }else if(d > 0){
		    double f = (-1 * b) - (Math.Sqrt(b * b - (4 * a * c) / (2 * a)));
		    Console.WriteLine("x1,2 is {0}",f);
		  }else{
		    Console.WriteLine("No root");
		  }
		  
		  
		}
	}
}