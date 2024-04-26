using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace HelloWorld
{
	public class Program
	{
	  static void nested1(int p, string[] arr){
	    if(p < 0){
	      return;
	    }
	    nested1(p - 1,arr);
      Console.WriteLine(arr[p]);
	  }
	  
	  static void nested2(int k, string[] arr,int n){
	    if(n > k){
	      return;
	    }
	          nested2(k,arr,n + 1);
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
		  string[] arr = {"Volvo", "BMW", "Ford","fun"};
		  int p = arr.Length;
		  
		  Console.WriteLine("()");
		  nested1(p - 1,arr);
		  nested2(k,arr,0);
		  foreach(string v in arr){
		    Console.Write(v);
		    Console.Write(",");
		  }
			
		}
	}
}