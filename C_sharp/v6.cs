using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace HelloWorld
{
public class MergeSort
{
    public static void Main(string[] args)
    {
        int[] numbers = { 38, 27, 43, 3, 9, 82, 10 };
        int len = numbers.Length;

        Console.WriteLine("Before sorting:");
        DisplayElements(numbers);

        Console.WriteLine("\nAfter sorting:");
        Sort(numbers, 0, len - 1);
        DisplayElements(numbers);
    }

    static void Merge(int[] numbers, int left, int mid, int right)
    {
        int[] temp = new int[right - left + 1];
        int i = left, j = mid + 1, k = 0;

        while (i <= mid && j <= right)
        {
            if (numbers[i] <= numbers[j])
                temp[k++] = numbers[i++];
            else
                temp[k++] = numbers[j++];
        }

        while (i <= mid)
            temp[k++] = numbers[i++];

        while (j <= right)
            temp[k++] = numbers[j++];

        for (i = left; i <= right; i++)
            numbers[i] = temp[i - left];
    }

    static void Sort(int[] numbers, int left, int right)
    {
        if (left < right)
        {
            int mid = left + (right - left) / 2;
            Sort(numbers, left, mid);
            Sort(numbers, mid + 1, right);
            Merge(numbers, left, mid, right);
        }
    }

    static void DisplayElements(int[] arr)
    {
        foreach (var element in arr)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }
}

}