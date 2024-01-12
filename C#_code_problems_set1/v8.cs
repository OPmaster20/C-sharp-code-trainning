using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace HelloWorld
{
	public class Program
	{
	  
	  public static void re(int x,int y,int r){
	    double e = (0 - x) * (0 - x) + (0 - y) * (0 - y);
	    if(e <= r * r){
	        Console.WriteLine(" Yes ");
	    }else{
	        Console.WriteLine(" No ");
	    }
	    

	  } 
		public static void Main()
		{
		    Console.WriteLine("Input: ");
			  int x = int.Parse(Console.ReadLine());
			  int y = int.Parse(Console.ReadLine());
			  int r = 5;
			  re(x,y,r);
		}
	}
}