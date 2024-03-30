using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace HelloWorld
{
  class Polynomial{
    //x - 1 = {-1,1}
    //3x^2 + 4x - 6 = {-6,4,3}
    int Max(int x, int y){
      if(x > y){
        return x;
      }
      return y;
    }
    public void Process(){
      int[] p1 = {-6,4,3};
      int[] p2 = {-1,1};
      int[] p_sum = new int[Max(p1.Length,p2.Length)];
    
      
      for(int i = 0; i < p_sum.Length; i++){
        if(i == p1.Length || i == p2.Length){
          if(p1.Length == Max(p1.Length,p2.Length)){
            p_sum[i] = p1[i] + 0; 
          }else{
             p_sum[i] = p2[i] + 0; 
          }
          Console.WriteLine(p_sum[i]);
          break;
        }
        p_sum[i] = p1[i] + p2[i];
        Console.WriteLine(p_sum[i]);
      }
      
    }
	
	}
	
	class Gate{
	  
	  public static void Main(string[] args){
			Polynomial p = new Polynomial();
			p.Process();
			
		}
	}
}