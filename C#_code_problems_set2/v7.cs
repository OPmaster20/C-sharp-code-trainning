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
		  int[] d = new int[5];
		  for(int i = 0; i < 5; i++){
		    d[i] = Convert.ToInt32(Console.ReadLine());
		  }
		  
		  Array.Sort(d);
		  Console.WriteLine(d[4]);
	

		  
		}
	}
}