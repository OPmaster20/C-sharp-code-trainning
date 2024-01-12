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
		  for(int i = 1; i <= a; i++){
		      Console.WriteLine(i);
		  }
		  
		  
		 
		}
	}
}