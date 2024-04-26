using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace HelloWorld
{
	public class Program
	{
	  static void nested(int[] k, int n,int target){
	    if(n <= 0){
	      return;
	    }
	    nested(k,n - 1,target);
	    for(int i = 0; i < k.Length; i++){
	      if(k[n] + k[i] == target){
	        Console.WriteLine(target + " = " + k[n] + " + " + k[i]);
	      }
	    }
	  }
	  
	  static void nested2(int[] k, int n,int target){
	    if(n <= 0){
	      return;
	    }
	    nested(k,n - 1,target);
	    for(int i = 0; i < k.Length / 2; i++){
	      if(k[n] + k[i] + k[i + 1] == target){
	        Console.WriteLine(target + " = " + k[n] + " + " + k[i] + " + " + k[i + 1]);
	      }
	    }
	  }
	  
		public static void Main(string[] args)
		{
		  int[] k = {2, 3, 1, -1};
		  int n = Convert.ToInt32(Console.ReadLine());
		  int[] num = new int[k.Length];
		  for(int j = 0; j < k.Length; j++){
		    num[j] = 0;
		  }
		  foreach(int v in k){
		    if(v == n){
		      Console.WriteLine(n + " = " + v);
		    }
		  }
		  nested(k,k.Length - 1,n);
			nested2(k,k.Length - 1,n);
		}
	}
}