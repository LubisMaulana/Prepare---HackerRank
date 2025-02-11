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
     * Complete the 'strangeCounter' function below.
     *
     * The function is expected to return a LONG_INTEGER.
     * The function accepts LONG_INTEGER t as parameter.
     */

    public static long strangeCounter(long t)
    {
        // 1, 4, 10, 22, 46 .... Un
        // 1 + (3* (2^0 - 1)) => 1
        // 1 + (3* (2^1 - 1)) => 4
        // 1 + (3* (2^2 - 1)) => 10
        // 1 + (3* (2^3 - 1)) => 22
        // 1 + (3* (2^4 - 1)) => 46
        // 1 + (3* (2^5 - 1)) => 94
        // ...
        // 1 + (3* (2^n - 1)) 
        // = (3* (2^n - 1)) + 3 - 2
        // = (3* (2^n - 1 + 1)) - 2
        // = (3* (2^n)) - 2 => formula for the n-th term

        // how to get n from (2^n), log2 (floor((time+2) / 2))
        long n = (int)Math.Floor(Math.Log((t+2) / 3, 2));
        
        long topValue = long.Parse((3 * Math.Pow(2, n)).ToString());
        long topTime = topValue - 2;

        return topValue - (t - topTime);
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        long t = Convert.ToInt64(Console.ReadLine().Trim());

        long result = Result.strangeCounter(t);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
