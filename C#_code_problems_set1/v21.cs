using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace HelloWorld
{
	public class Program
	{
	  static void re(int a, int b){
	    for(int i = a; i <= b; i++){
	      if(i % 5 == 0){
	        Console.WriteLine(i);
	      }
	    }
	  }
		public static void Main(string[] args)
		{
		  int a = Convert.ToInt32(Console.ReadLine());
		  int b = Convert.ToInt32(Console.ReadLine());
		  
		  re(a,b);
		}
	}
}