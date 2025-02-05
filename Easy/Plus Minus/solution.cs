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
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void plusMinus(List<int> arr)
    {
        int length = arr.Count, sumMin = 0, sumPlus = 0, sumZero = 0;
        
        for(int i = 0; i < length; i++){
            if(arr[i] > 0){
                sumPlus++;
            }else if(arr[i] < 0){
                sumMin++;
            }else{
                sumZero++;
            }
        }
        
        Console.WriteLine($"{(double)sumPlus/length}");
        Console.WriteLine($"{(double)sumMin/length}");
        Console.WriteLine($"{(double)sumZero/length}");
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.plusMinus(arr);
    }
}
