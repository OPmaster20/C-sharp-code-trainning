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
		  string[] single_english = {"zero","one","two","three",
		  "four","five","six","seven",
		  "eight","nine","ten","eleven","twelve",
		  "thirteen","fourteen","fifteen",
		  "sixteen","seventeen","eightteen","nineteen"};
		  
		  string[] double_english = {"twenty","thirty","forty","fifty",
		  "sixty","seventy","eighty","ninety"};
		  int n = Convert.ToInt32(Console.ReadLine());
		  if(n <= 19){
		    Console.WriteLine("{0} --> {1}",n,single_english[n]);
		  }else if(n >= 20 && n <= 99){
		    if(n % 10 == 0){
		      Console.WriteLine("{0} --> {1}",n,double_english[(n/10)-2]);
		    }else{
		      Console.WriteLine("{0} -->{1} {2}",n,double_english[(n/10)-2],single_english[(n%10)]);
		    }
		  }else if(n > 100 && n <= 999){
		    if((n % 10 == 0) && (n /10 % 10 == 0)){
		      Console.WriteLine("{0} --> {1} hundred",n,single_english[(n/100)]);
		    }else if(n % 100 <= 19){
		      Console.WriteLine("{0} --> {1} hundred and {2}",n,single_english[(n/100)],single_english[(n%100)]);
		    }else{
		      Console.WriteLine("{0} --> {1} hundred {2} {3}",n,single_english[(n/100)],double_english[(n/10%10) - 2],single_english[(n%10)]);
		    }
		  }else{
		     Console.WriteLine("{0} --> one hundred",n);
		  }
		  
		  
		}
	}
}