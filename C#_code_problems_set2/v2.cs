using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using static System.Math;

namespace HelloWorld
{
	public class Program
	{
	  
		public static void Main(string[] args)
		{
		  double[] d1 = new double[3];
		  d1[0] = 0;
		  d1[1] = 1.34;
		  d1[2] = -3.45;
		  
		  int counter = 0;
		  for(int i = 0; i < 3; i++){
		    if(d1[i] == 0){
		      Console.WriteLine("0");
		      continue;
		    }
		    
		    if(d1[i] < 0){
		      counter++;
		    }
		  
		    if(counter % 2 == 0){
		      Console.WriteLine("+");
		    }else{
		      Console.WriteLine("-");
		    }
		  }
		  
		  
		  
		  
		}
	}
}