using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace HelloWorld{
  
	class Pin{
	  public int n;
	  public int[] arr = {3,2,2,5,1,-8,7,2};

		public void Get_times(){
		  int time = 0;
		  foreach(int i in arr){
		    if(i == n){
		      time = time +1;
		    }
		  }
		  Console.WriteLine("{0}",time);
		}
	}
	
	class Gate{
	  public static void Main(string[] args){
	    Pin m = new Pin();
	    m.n = Convert.ToInt32(Console.ReadLine());
	    m.Get_times();
	  }
	}
}