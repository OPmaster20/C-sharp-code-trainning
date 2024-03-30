using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace HelloWorld{
  
	class Pin{
	  public int n;
		
		public void Print_reversed(){
		  int r = 10;
		  int y = 1;
		  while(true){
		    int k = n % r / y;
		    if(k == 0){
		      break;
		    }
		    Console.Write(k);
		    r = r * 10;
		    y = y * 10;
		  }
		}
	}
	
	class Gate{
	  public static void Main(string[] args){
	    Pin m = new Pin();
	    m.n = Convert.ToInt32(Console.ReadLine());
	    m.Print_reversed();
	  }
	}
}