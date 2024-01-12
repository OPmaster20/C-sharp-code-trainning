using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace HelloWorld
{
	public class Program
	{
	  public static int re(int n){
	    int d = n / 100 % 10; 
	    return d;
	    
	    
	  } 
		public static void Main(string[] args)
		{
			  int n = 3750;
			  
			  int result = re(n);
			  if(result == 7){
			    Console.WriteLine("Yes");
			  }else{
			    Console.WriteLine("No");
			  }
			  
		}
	}
}