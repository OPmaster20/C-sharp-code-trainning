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
		  int[] d = new int[3];
		  d[0] = 5;
		  d[1] = 4;
		  d[2] = 1;
		  
		  Array.Sort(d);
		  for(int i = 0; i < 3; i++){
		    Console.WriteLine(d[i]);
		  }
		  
		  
		}
	}
}