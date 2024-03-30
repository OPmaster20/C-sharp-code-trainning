using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace HelloWorld{
  
	class Pin{
	  //public int n;
		public int[] arr = {3,2,2,5,1,-8,7,2};
		
		public void Sorting(){
		  for(int i = 1; i <= arr.Length; i++){
		    for(int j = 0; j < arr.Length - i; j++){
		      if(arr[j] < arr[j + 1]){
		        int temp = arr[j + 1];
		        arr[j + 1] = arr[j];
		        arr[j] = temp;
		      }
		    }
		    
		  }
		}
		
		public void Find_biggest_print(){
		  for(int i = 0;i < arr.Length; i++){
		    Console.Write(arr[i]);
		  }
		  Console.WriteLine();
		  Console.WriteLine("The biggest number is {0}",arr[0]);
		}
	}
	
	class Gate{
	  public static void Main(string[] args){
	    Pin m = new Pin();
	    //m.n = Convert.ToInt32(Console.ReadLine());
	    m.Sorting();
	    m.Find_biggest_print();
	    
	  }
	}
}