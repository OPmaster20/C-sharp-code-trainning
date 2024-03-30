using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace HelloWorld
{
  class Objects{
    public string number1;
    public string number2;
    
    bool Check(int x, int y){
      if(x + y >= 10){
        return true;
      }
      return false;
    }
    
    public void Process(){
      int[] n1 = new int[number1.Length];
      int[] n2 = new int[number2.Length];
      int[] sum = new int[number1.Length];
      for(int i = 0; i < number1.Length ;i++){
        n1[i] = number1[i] - '0';
      }
      for(int j = 0; j < number2.Length ;j++){
        n2[j] = number2[j] - '0';
      }
      
      int z = number1.Length - 1;
      int k = 0;
      int p = 0;
      while(z >= 0){
        if(p != 0){
          n1[z] = n1[z] + p;
          p = 0;
        }
        if(Check(n1[z],n2[z])){
          sum[k] = (n1[z] + n2[z]) % 10;
          k++;
          z--;
          p = 1;
        }else{
          sum[k] = n1[z] + n2[z];
          z--;
          k++;
        }
      }
      
      for(int x = number1.Length - 1; x >= 0; x--){
        Console.Write(sum[x]);
      }
      
    }
	
	}
	
	class Gate{
	  
	  public static void Main(string[] args){
			Objects p = new Objects();
			p.number1 = Console.ReadLine();
			p.number2 = Console.ReadLine();
			p.Process();
			
		}
	}
}