using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace HelloWorld
{
	public class Program
	{
	  public static int re(int n){
	    int i = 0;
	    int d = 0;
	    while(i < 8){
	      if(i == 2){
	        d = n % 2;
	      }
	      Console.WriteLine(n % 2);
	      n = n / 2;
	      ++i;
	    }
	    
	    return d;
	    
	    
	  } 
		public static void Main(string[] args)
		{
			  int n = 3;
			  Console.WriteLine("the number is " + re(n));
		}
	}
}