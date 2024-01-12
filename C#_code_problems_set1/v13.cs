using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace HelloWorld
{
	public class Program
	{
	  static int re(int n,int v,int p){
	    int i = 0;
	    int k = 1;
	    int d = 0;
	    int x = 255;
	    x = x - 1;
	    if(p > 1){
	      while(i < p){
	        k = k * 2;
	        x = x - 1;
	        i++;
	      }
	    }
	 
	    if(v == 1){
	      d = n | k;
	    }else{
	      d = n & (~(1 << p));
	    }
	    
	    return d;
	    
	    
	  } 
		public static void Main(string[] args)
		{
			  int n = int.Parse(Console.ReadLine());
			  int v = int.Parse(Console.ReadLine());
			  int p = int.Parse(Console.ReadLine());
			  
			  n = re(n,v,p);
			  Console.WriteLine(n);
		}
	}
}