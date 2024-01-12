using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace HelloWorld
{
	public class Program
	{
	  static int re(){
	    while(true){
	      int a = Convert.ToInt32(Console.ReadLine());
	      if(a >= 0){
	        return a;
	      }
	    }
	    
	  }
	  
		public static void Main(string[] args)
		{
		  int a = re();
		  int b = re();
		  int c = re();
		  int d = re();
		  int e = re();
		  Console.WriteLine(a+b+c+d+e);
		 
		}
	}
}