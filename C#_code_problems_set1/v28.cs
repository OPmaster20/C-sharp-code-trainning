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
		  double x = 1.0;
		  for(int i = 2; i <= 100; i++){
		    if(i % 2 == 0){
		      x = x + 1/(double)i;
		    }else{
		      x = x - 1/(double)i;
		    }
		    
		    
		  }
		  Console.WriteLine(x);
		  
		  
		 
		}
	}
}