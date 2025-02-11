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
     * Complete the 'closestNumbers' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static List<int> closestNumbers(List<int> arr)
    {
        List<int> sortedArr = arr.OrderBy(item => item).ToList();
        List<int> diffArr = new List<int>();
        
        for(int i = 1; i < arr.Count; i++){
            diffArr.Add(sortedArr[i] - sortedArr[i-1]);
        }
        
        int minDiff = diffArr.Min();
        List<int> result = new List<int>();
        
        diffArr.Select((val, index) => new {val, index}).ToList().ForEach(item => {
            if(item.val == minDiff){
                result.Add(sortedArr[item.index]);
                result.Add(sortedArr[item.index + 1]);
            }
        });
        
        return result;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        List<int> result = Result.closestNumbers(arr);

        textWriter.WriteLine(String.Join(" ", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
