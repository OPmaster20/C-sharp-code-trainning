using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace HelloWorld{
  
	class Memu{
	  public int c;
		
		public bool Check(){
		  if(c >= 1 && c <= 3){
		    return true;
		  }
		  return false;
		}
		
		public void Called(){
		  switch(c){
		      case 1:
		        Reversed_order();
		        break;
		      case 2:
		        Average();
		        break;
		      case 3:
		        Linear();
		        break;
		      default:
		        Console.WriteLine("No task can choice!");
		        break;
		  }
		}
		void Reversed_order(){
		  int n = 0;
		  while(true){
		    Console.WriteLine("Input number:");
		    n = Convert.ToInt32(Console.ReadLine());
		    if(n >= 0){
		      break;
		    }
		  }
		  
		  if(n >= 10){
		    int r = 10;
		    int y = 1;
		    while(true){
		      int k = n % r / y;
		      if(k == 0){
		        break;
		      }
		      Console.Write(k);
		      r = r * 10;
		      y = y * 10;
		    }
		  }else{
		    Console.WriteLine("{0}",n);
		  }
		  
		}
		
		void Average(){
		  int length = 0;
		  while(true){
		    Console.WriteLine("input length of sequence");
		    length = Convert.ToInt32(Console.ReadLine());
		    if(length > 0){
		      break;
		    }
		  }
		  int[] arr = new int[length];
		  int sum = 0;
		  for(int i = 0;i < length; i++){
		    arr[i] = Convert.ToInt32(Console.ReadLine());
		    sum += arr[i];
		  }
		  Console.WriteLine("average is {0}",sum/length);
		  
		  
		}
		
		void Linear(){
		  int a = 0;
		  while(true){
		     Console.WriteLine("input a:");
		     a = Convert.ToInt32(Console.ReadLine());
		     if(a > 0){
		       break;
		     }
		  }
		  Console.WriteLine("input b:");
		  int b = Convert.ToInt32(Console.ReadLine());
		  float m = -1*(b/a)
		  Console.WriteLine("a * x + b = 0 is {0}",m);
		}
		
		
		
	}
	
	class Gate{
	  public static void Main(string[] args){
	    Memu m = new Memu();
	    while(true){
	      Console.WriteLine("Input 1: Reversed_order");
	      Console.WriteLine("Input 2: average of given sequence");
	      Console.WriteLine("Input 3: linear equation a * x + b = 0");
	      m.c = Convert.ToInt32(Console.ReadLine());
	      if(m.Check()){
	        m.Called();
	      }
	    }
	    
	  }
	}
}