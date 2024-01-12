/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;
class HelloWorld {
  static void Main() {
        int num = 45;
        int bit3 = (num >> 3) & 1;
        int bit24 = (num >> 24) & 1;
        num = num & (~(1 << 24)) | (bit3 << 24);
        num = num & (~(1 << 3)) | (bit24 << 3);
        
        int bit4 = (num >> 4) & 1;
        int bit25 = (num >> 25) & 1;
        num = num & (~(1 << 25)) | (bit3 << 25);
        num = num & (~(1 << 4)) | (bit24 << 4);
        
        int bit5 = (num >> 5) & 1;
        int bit26 = (num >> 26) & 1;
        num = num & (~(1 << 26)) | (bit3 << 26);
        num = num & (~(1 << 5)) | (bit24 << 5);
    Console.WriteLine(num);
  }
}
