using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace HelloWorld{
  
	class Pin{
	  public int p;
	  public int[] arr = {3,2,2,5,1,-8,7,2};

		public bool If_outborder(){
		  if(p > arr.Length || p < 0){
		    return true;
		  }
		  return false;
		}
		
		public void If_greater(){
		  if(arr[p] > arr[p + 1] && arr[p] > arr[p - 1]){
		    Console.WriteLine("True");
		  }else{
		    Console.WriteLine("False");
		  }
		}
	}
	
	class Gate{
	  public static void Main(string[] args){
	    Pin m = new Pin();
	    m.p = Convert.ToInt32(Console.ReadLine());
	    if(!m.If_outborder()){
	      m.If_greater();
	    }else{
	      Console.WriteLine("outside the bounds of the array");
	    }
	  }
	}
}