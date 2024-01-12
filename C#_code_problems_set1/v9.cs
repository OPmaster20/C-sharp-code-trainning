using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace HelloWorld
{
	public class Program
	{
	  
	  public static void re(int x,int y,int r,int t1,int t2,int tt1,int tt2){
	    double e = (0 - x) * (0 - x) + (0 - y) * (0 - y);
	    if((e <= r * r) && ((x>t1 && x<tt1) && (y>t2 && y<tt2))){
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
			  int t1 = -1;
			  int t2 = 1;
			  int tt1 = 5;
			  int tt2 = 5;
			  re(x,y,r,t1,t2,tt1,tt2);
		}
	}
}