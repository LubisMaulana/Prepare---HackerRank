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
     * Complete the 'kaprekarNumbers' function below.
     *
     * The function accepts following parameters:
     *  1. INTEGER p
     *  2. INTEGER q
     */

    public static void kaprekarNumbers(int p, int q)
    {
        List<int> result = new List<int>();
        
        for(int i = p; i <= q; i++){
            long pow = i * i;
            string strPow = pow.ToString();
            int mid = strPow.Length / 2;
            
            string strNumber1 = strPow.Substring(0, mid);
            int number1 = int.Parse(strNumber1 == "" ? "0" : strNumber1);
            string strNumber2 = strPow.Substring(mid, (strPow.Length % 2 == 0 ? mid : mid + 1));
            int number2 = int.Parse(strNumber2 == "" ? "0" : strNumber2);
            
            if(number1 + number2 == i){
                result.Add(i);
            }
        }
        
        if(result.Count > 0){
            string strResult = String.Join(' ', result);
            Console.WriteLine($"{strResult}");
        }else{
            Console.WriteLine("INVALID RANGE");
        }
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int p = Convert.ToInt32(Console.ReadLine().Trim());

        int q = Convert.ToInt32(Console.ReadLine().Trim());

        Result.kaprekarNumbers(p, q);
    }
}
