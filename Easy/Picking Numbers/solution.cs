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
     * Complete the 'pickingNumbers' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY a as parameter.
     */

    public static int pickingNumbers(List<int> a)
    {
        int min = a.Min() + 1;
        var arr = new Dictionary<int, int>();

        while (a.Count > 0) {
            for (int i = 0; i < a.Count;) {
                if (a[i] <= min) {
                    if (arr.ContainsKey(min)) {
                        arr[min] += 1;
                    } else {
                        arr[min] = 1;
                    }
                    a.RemoveAt(i);
                } else {
                    i++;
                }
            }
            if (a.Count > 0) {
                min = a.Min() + 1;
            }
        }

        return arr.Values.Max();
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

        int result = Result.pickingNumbers(a);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
