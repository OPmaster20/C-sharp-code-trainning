using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace HelloWorld
{
	public class Program
	{
		public static void Main(string[] args)
		{
	    Console.WriteLine("{0,10:X}",Convert.ToInt16(8));
	    Console.WriteLine("{0,10:f2}",1.34);
	    Console.WriteLine("{0,10:f2}",-5.67);
		}
	}
}