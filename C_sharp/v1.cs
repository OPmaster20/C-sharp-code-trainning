using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace HelloWorld
{
	public class Program
	{
	  static void nested(int k){
	    if(k < 0){
	      return;
	    }
	    nested(k - 1);
	    Console.WriteLine("Hello, World!");
	    
	    
	    
	  }
		public static void Main(string[] args)
		{
		  int k = Convert.ToInt32(Console.ReadLine());
		  nested(k);
			
		}
	}
}