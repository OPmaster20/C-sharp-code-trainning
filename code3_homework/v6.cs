using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace HelloWorld{
  
	class Pin{
	  public int n;
	  public int[] arr = {3,2,2,5,1,-8,7,2};
		
		public int Print_position(){
		 for(int i = 1; i < arr.Length - 1; i++){
		   if(arr[i] == n){
		     if(arr[i] > arr[i + 1] && arr[i] > arr[i - 1]){
		        return i;
		     }
		   }
		 }
		 return -1;
		}
	}
	
	class Gate{
	  public static void Main(string[] args){
	    Pin m = new Pin();
	    m.n = Convert.ToInt32(Console.ReadLine());
	    Console.WriteLine(m.Print_position());
	  }
	}
}