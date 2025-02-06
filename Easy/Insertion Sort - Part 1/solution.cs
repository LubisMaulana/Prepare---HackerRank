using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'insertionSort1' function below.
     *
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. INTEGER_ARRAY arr
     */

    public static void insertionSort1(int n, List<int> arr)
    {
        string result;
        for (int i = n - 1; i >= 0; i--){
            int index = i;
            int temp = arr[i];
            for (int j = i-1; j >= 0 && arr[j] > temp; j--){
                arr[j+1] = arr[j];
                index = j;
                
                result = String.Join(" ", arr);
                Console.WriteLine(result);
            }
            
            arr[index] = temp;
        }
        
        result = String.Join(" ", arr);
        Console.WriteLine(result);
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.insertionSort1(n, arr);
    }
}
