using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text.RegularExpressions;

namespace HelloWorld
{

public class Program
{
    public static void Main()
    {
        int[] array = { 3, 34, 4, 12, 5, 2 };
        int sum = 9;

        bool exists = IsSubsetSum(array, array.Length, sum);
        Console.WriteLine("Is there a subset whose sum is equal to S: " + exists);
    }

    public static bool IsSubsetSum(int[] array, int n, int sum)
    {
     
        if (sum == 0)
            return true;
        if (n == 0 && sum != 0)
            return false;


        if (array[n - 1] > sum)
            return IsSubsetSum(array, n - 1, sum);

       
        return IsSubsetSum(array, n - 1, sum) || IsSubsetSum(array, n - 1, sum - array[n - 1]);
    }
}






}