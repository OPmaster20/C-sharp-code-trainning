using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace HelloWorld{
  
	class Pin{
	  public int n;
		public int[] arr = {3,2,2,5,1,-8,7,2};
		
		public void Print(){
		  int k = 1;
		  for(int i = 1; i <= n; i++){
		    k = k * i;
		  }
		  Console.WriteLine("{0}! is {1}",n,k);
		}
		public bool Check(){
		  if(n >= 1 && n <= 100){
		    return true;
		  }
		  Console.WriteLine("Out of range");
		  return false;
		}
		
		
	}
	
	class Gate{
	  public static void Main(string[] args){
	    Pin m = new Pin();
	    m.n = Convert.ToInt32(Console.ReadLine());
	    if(m.Check()){
	      m.Print();
	    }
	  }
	}
}