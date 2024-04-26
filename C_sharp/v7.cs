using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace HelloWorld
{
	public class Program
	{
	  static void Print(int[] arr){
	    foreach(int i in arr){
	      Console.Write(i);
	      Console.Write(",");
	    }
	    Console.WriteLine();
	  }
	  static void sort(int[] array,int n,int t){
	    if(t >= n){
	      return;
	    }
	    sort(array,n,t + 1);
	    for(int j = 0; j < array.Length - 1; j++){
	      int k = array[j];
	      array[j] = array[j + 1];
	      array[j + 1] = k;
	      Print(array);
	    }
	   
	    
	    
	    
	  }
		public static void Main(string[] args)
		{
		  int n = Convert.ToInt32(Console.ReadLine());
		  int[] array = new int[n];
		  for(int i = 0;i < n; i++){
		    array[i] = (i + 1);
		  }
		  sort(array,(n),0);
		  
		  
			
		}
	}
}