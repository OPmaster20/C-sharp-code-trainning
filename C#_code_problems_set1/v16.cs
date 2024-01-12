/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;
class HelloWorld {
    
  static void ex(int num,int k,int q){
      
      for(int i = 0,j = q; i < k; i++,j++){
          int bit0 = (num >> i) & 1;
          int bit1 = (num >> q) & 1;
          num = num & (~(1 << q)) | (bit0 << q);
          num = num & (~(1 << i)) | (bit1 << i);
          
      }
      
      Console.WriteLine(num);
        
      
  }
  static void Main() {
        int num = 45;
        ex(num,10,12);
  }
}
