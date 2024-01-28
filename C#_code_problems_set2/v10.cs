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
		    int n = 7;
		    if(n >= 1 && n <= 3){
		      Console.Write(n*10);
		    }else if((n >= 4 && n <= 6)){
		      Console.Write(n*100);
		    }else if((n >= 7 && n <= 9)){
		      Console.Write(n*1000);
		    }else if((n == 0 || n > 9)){
		      Console.Write("error");
		    }
	

		  
		}
	}
}