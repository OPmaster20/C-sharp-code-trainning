using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace HelloWorld
{
	public class Program
	{
	  static void fun1(string n){
	    int i = 0;
	    int d = 0;
	    int g = 0;
	    while(i < n.Length){
	      g = (int)n[i] - 48;
	      d = d + g;
	      i++;
	    }
	    Console.WriteLine(d);
	    
	  }
	  
	  static void fun2(string n){
	    int i = n.Length - 1;
	    while(i >= 0){
	      Console.WriteLine(n[i]);
	      i--;
	    }
	   
	  }
	  
	  static void fun3(string n){
	    char[] t = new char[n.Length + 1];
	    t[0] = n[n.Length - 1];
	    int j = 1;
	    for(int i = 0; i < n.Length; i++,j++){
	      t[j] = n[i];
	      Console.Write("{0}",t[i]);
	    }
	    
	   
	  }
	  
	  static void fun4(string n){
	    char[] t = new char[n.Length];
	    int i = 0;
	    while(i < n.Length){
	      t[i] = n[i];
	      i++;
	    }
	    i = 0;
	    char k = t[1];
	    t[1] = t[2];
	    t[2] = k;
	    while(i < n.Length){
	      Console.Write("{0}",t[i]);
	      i++;
	    }
	    
	    
	  }
	  
		public static void Main(string[] args)
		{
			string n = Console.ReadLine();
			fun4(n);
		}
	}
}