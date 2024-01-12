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
		  int x = 0;
		  int y = 1;
		  int z = 0;
		  Console.WriteLine(x);
		  Console.WriteLine(y);
		  for(int i = 1; i <= 10; i++){
		    z = x + y;
		    Console.WriteLine(z);
		    int t = x;
		    x = y;
		    y = t;
		    
		    int t2 = y;
		    y = z;
		    z = t2;
		  }
		  
		  
		 
		}
	}
}