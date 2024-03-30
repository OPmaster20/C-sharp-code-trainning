using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace HelloWorld{
  
	class Max{
	  public int a;
	  public int b;
	  public int c;
	  
		public int GetMax(int x, int y){
		  if(x > y){
		    return x;
		  }
		  return y;
		}
	}
	
	class Gate{
	  public static void Main(string[] args){
	    Max m = new Max();
	    m.a = Convert.ToInt32(Console.ReadLine());
	    m.b = Convert.ToInt32(Console.ReadLine());
	    m.c = Convert.ToInt32(Console.ReadLine());
	    
	    int n = m.GetMax(m.GetMax(m.a,m.b),m.c);
	    Console.WriteLine("Max number is {0}",n);
	  }
	}
}