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
		  int d1 = 0;
		  int d2 = 45;
		  int d3 = 95;
		  
		  if(d1 > d2){
		    if(d1 > d3){
		      Console.WriteLine("d1 is big");
		    }else{
		      Console.WriteLine("d3 is big");
		    }
		  }else{
		    if(d2 > d3){
		      Console.WriteLine("d2 is big");
		    }else{
		      Console.WriteLine("d3 is big");
		    }
		  }
		  
		  
		}
	}
}