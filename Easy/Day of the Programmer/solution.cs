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
     * Complete the 'dayOfProgrammer' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts INTEGER year as parameter.
     */

    public static string dayOfProgrammer(int year)
    {
        bool kabisat = false;
        int tgl = 256 - 243;
        if(year % 400 == 0 || 
            (year > 1917 && ((year % 100 != 0 && year % 4 == 0))) ||
            ((year <= 1917 && year >= 1700) && ((year % 100 == 0 || year % 4 == 0)))){
            kabisat = true;
        }
        
        if(kabisat){
            tgl--;
        }
        
        if(year == 1918){
            tgl += 13; // because February in the year 1918 started from the 14th
        }
        return $"{tgl}.09.{year}";
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int year = Convert.ToInt32(Console.ReadLine().Trim());

        string result = Result.dayOfProgrammer(year);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
