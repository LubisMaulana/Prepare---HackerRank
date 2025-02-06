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
     * Complete the 'countSort' function below.
     *
     * The function accepts 2D_STRING_ARRAY arr as parameter.
     */

    public static void countSort(List<List<string>> arr)
    {
        List<List<string>> result = Enumerable.Range(0,100).Select(x => new List<string>()).ToList();
        
        List<string> finalResult = new List<string>();
        for (int i = 0; i < arr.Count; i++){
            if (i <= (arr.Count / 2) - 1){
                result[int.Parse(arr[i][0])].Add("-");
            }else{
                result[int.Parse(arr[i][0])].Add(arr[i][1]);
            }
        }
        
        result.RemoveAll(list => list.Count < 1);
        for(int i = 0; i < result.Count; i++){
            finalResult.Add(String.Join(" ", result[i]));
        }

        Console.WriteLine($"{String.Join(" ", finalResult)}");
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<List<string>> arr = new List<List<string>>();

        for (int i = 0; i < n; i++)
        {
            arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList());
        }

        Result.countSort(arr);
    }
}
