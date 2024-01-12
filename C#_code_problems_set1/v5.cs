using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace HelloWorld
{
	public class Program
	{
	  public static float re(float a,float b,float h){
	    float d = ((a + b) * h) / 2;
	    return d;

	  } 
		public static void Main(string[] args)
		{
			  float a = 3;
			  float b = 4;
			  float h = 5;
			  Console.WriteLine("the number is " + re(a,b,h));
		}
	}
}