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
    
    int Min(int x, int y){
      if(x < y){
        return x;
      }
      return y;
    }
    
    public void Process(){
      int[] p1 = {-3,1,3};
      int[] p2 = {-1,1};
      int[] p_sum = new int[Max(p1.Length,p2.Length) * 2];
      int[] identifier = new int[Max(p1.Length,p2.Length) * 2];
      
      int k = 0;
      for(int i = Max(p1.Length,p2.Length) - 1; i >= 0; i--){
        for(int j = Min(p1.Length,p2.Length) - 1; j >= 0; j--){
          if(p1.Length == Min(p1.Length,p2.Length)){
            p_sum[k] = p2[i] * p1[j];
            identifier[k] = i + j;
            k++;
          }else{
            p_sum[k] = p1[i] * p2[j];
            identifier[k] = i + j;
            k++;
          }
           
        }
      }
      
      for(k = 0; k < identifier.Length - 1; ){
        if(identifier[k] == identifier[k + 1]){
          Console.WriteLine(p_sum[k] + p_sum[k + 1]);
          k+=2;
        }else{
          Console.WriteLine(p_sum[k]);
          k++;
        }
        if(k == identifier.Length - 1){
          Console.WriteLine(p_sum[k]);
        }
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