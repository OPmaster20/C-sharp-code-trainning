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
		  int v1 = Convert.ToInt32(Console.ReadLine());
		  int v2 = Convert.ToInt32(Console.ReadLine());
		  Console.WriteLine("{0} and {1}",v1,v2);
			if(v1 > v2){
			  int t = v1;
			  v1 = v2;
			  v2 = t;
			  Console.WriteLine("{0} and {1}",v1,v2);
			}
		}
	}
}