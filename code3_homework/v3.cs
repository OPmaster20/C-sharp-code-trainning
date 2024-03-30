using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace HelloWorld{
  
	class Pin{
	  public int n;
	  public string[] ename = {"zero","one","two","three","four","five","six","seven","eight","nine"}; 
	  public void Get_last(){
	    n = n % 10;
	  }
		public void Print_name(){
		  Console.WriteLine("{0}",ename[n]);
		}
	}
	
	class Gate{
	  public static void Main(string[] args){
	    Pin m = new Pin();
	    m.n = Convert.ToInt32(Console.ReadLine());
	    m.Get_last();
	    m.Print_name();
	  }
	}
}