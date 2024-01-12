using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace HelloWorld
{
	public class Program
	{
	  public static bool re(int n){
	    if(n % 5 == 0 && n % 7 == 0){
            return true;
      }else{
            return false;
      }
	    
	  } 
		public static void Main(string[] args)
		{
			  int n = 35;
        if(re(n)){
          Console.WriteLine("True");
        }else{
          Console.WriteLine("False");
        }
		}
	}
}