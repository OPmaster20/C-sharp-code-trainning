using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace HelloWorld
{
	public class Program
	{
	  static void nested(int k, int[] arr){
	    if(k < 0){
	      return;
	    }
	    
	    //for(int i = 0; i < arr.Length; i++){
	          nested(k - 1,arr);
            for(int j = 0; j < arr.Length; j++){
                Console.Write(arr[k]);
                Console.Write(",");
                Console.Write(arr[j]);
                Console.WriteLine("");
            }
        //}

	  }
	  
		public static void Main(string[] args)
		{
		  int n = Convert.ToInt32(Console.ReadLine());
		  int k = Convert.ToInt32(Console.ReadLine());
		  int[] arr = new int[n];
		  for(int i = 0; i < n; i++){
		    arr[i] = i + 1;
		  }
		  nested(k,arr);
			
		}
	}
}