using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace HelloWorld
{
	public class Program
	{
	  static bool check(int[] num,int k, int j){
	    foreach(int i in num){
                  if(i == k + j){
                    return false;
                  }
          }
          return true;
	  }
	  
	  static void nested(int k, int[] arr,int[] num){
	    if(k < 0){
	      return;
	    }
	    
	    
	    //for(int i = 0; i < arr.Length; i++){
	          nested(k - 1,arr,num);
            for(int j = 0; j < arr.Length; j++){
                if(check(num,arr[k],arr[j])){
                Console.Write(arr[k]);
                Console.Write(",");
                Console.Write(arr[j]);
                Console.WriteLine("");
                num[j] = arr[k] + arr[j];
                }  
                
                
            }
        //}

	  }
	  
		public static void Main(string[] args)
		{
		  int n = Convert.ToInt32(Console.ReadLine());
		  int k = Convert.ToInt32(Console.ReadLine());
		  int[] arr = new int[n];
		  int[] num = new int[n];
		  for(int i = 0; i < n; i++){
		    arr[i] = i + 1;
		    num[i] = 0;
		  }
		  nested(k,arr,num);
			
		}
	}
}