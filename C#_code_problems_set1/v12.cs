using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace HelloWorld
{
	public class Program
	{
	  static bool re(int n,int p){
	    int i = 0;
	    int d = 0;
	    while(i <= p){
	      d = n % 2;
	      Console.WriteLine(d);
	      n = n / 2;
	      ++i;
	    }
	    if(d == 1){
	      return true;
	    }
	    return false;
	    
	    
	  } 
		public static void Main(string[] args)
		{
			  int n = int.Parse(Console.ReadLine());
			  int p = int.Parse(Console.ReadLine());
			  if(re(n,p)){
			    Console.WriteLine("True");
			  }else{
			    Console.WriteLine("False");
			  }
			  
		}
	}
}