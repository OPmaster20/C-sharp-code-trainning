using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace HelloWorld
{
	public class Program
	{
	  
	  static void nested(int k, string[] arr,int n){
	    if(n > k){
	      return;
	    }
	    
	    
	 
	          nested(k,arr,n + 1);
            for(int j = n + 1; j <= arr.Length - 1; j++){
              Console.Write(arr[n]);
              Console.Write(",");
              Console.Write(arr[j]);
              Console.WriteLine("");
            }

	  }
	  
		public static void Main(string[] args)
		{
		  int k = Convert.ToInt32(Console.ReadLine());
		  string[] arr = {"Volvo", "BMW", "Ford"};
		  nested(k,arr,0);
			
		}
	}
}