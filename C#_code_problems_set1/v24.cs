using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using static System.Math;
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
		  
		  Console.WriteLine(Math.Max(Math.Max(Math.Max(a,b),Math.Max(c,d)),e));
		 
		}
	}
}