using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace HelloWorld
{
	public class Program
	{
	  static int re(int n){
	    for(int i = 2; i < n; i++){
	      if(n % 2 == 0){
	        return 1;
	      }
	    }
	    return 0;
	    
	  } 
		public static void Main(string[] args)
		{
		  int n = 0;
		  while(true){
		    n = int.Parse(Console.ReadLine());
			  if(n > 1 && n < 100){
			    break;
			  }
		  }
			  int t = re(n);
			  if(t == 1){
			    Console.WriteLine("No");
			  }else{
			    Console.WriteLine("Yes");
			  }
		}
	}
}