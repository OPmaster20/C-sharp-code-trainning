using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace HelloWorld{
  
	class Person{
	  public string name;
		public void Print_name(){
			Console.WriteLine("Hello,{0}",name);
		}
	}
	
	class Gate{
	  public static void Main(string[] args){
	    Person p = new Person();
	    p.name = Console.ReadLine();
	    p.Print_name();
	  }
	}
}