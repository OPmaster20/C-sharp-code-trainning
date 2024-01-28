using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace HelloWorld
{
	public class Program
	{
		public static void Main(string[] args)
		{
		  int[] d = {3, 1, -7, 35, 22};
      int[] o = new int[5];
      
		  Array.Sort(d);
		  
		  if(d[0] < 0){
		    int k = 0;
		    for(int i = 0; i <= 4; i++){
		      k = k + d[i];
		      o[i] = d[i];
		      if(k == 0){
		        break;
		      }
		    }
		    
		    if(k != 0){
		      Console.WriteLine("No subsets with sum 0");
		    }else{
		      foreach(int i in o){
		        Console.WriteLine(i);
		      }
		    }
		    
  		  
		  }else{
		    Console.WriteLine("No subsets with sum 0");
		  }
		  
		  
		  
		  
		  
		  
		  
		  
		  
			
		}
	}
}