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
     * Complete the 'formingMagicSquare' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts 2D_INTEGER_ARRAY s as parameter.
     */

    public static int formingMagicSquare(List<List<int>> s)
    {
        List<List<List<int>>> magicSquares = new List<List<List<int>>>()
        {
            new List<List<int>> { new List<int> {8, 1, 6}, new List<int> {3, 5, 7}, new List<int> {4, 9, 2} },
            new List<List<int>> { new List<int> {6, 1, 8}, new List<int> {7, 5, 3}, new List<int> {2, 9, 4} },
            new List<List<int>> { new List<int> {4, 9, 2}, new List<int> {3, 5, 7}, new List<int> {8, 1, 6} },
            new List<List<int>> { new List<int> {2, 9, 4}, new List<int> {7, 5, 3}, new List<int> {6, 1, 8} },
            new List<List<int>> { new List<int> {8, 3, 4}, new List<int> {1, 5, 9}, new List<int> {6, 7, 2} },
            new List<List<int>> { new List<int> {4, 3, 8}, new List<int> {9, 5, 1}, new List<int> {2, 7, 6} },
            new List<List<int>> { new List<int> {6, 7, 2}, new List<int> {1, 5, 9}, new List<int> {8, 3, 4} },
            new List<List<int>> { new List<int> {2, 7, 6}, new List<int> {9, 5, 1}, new List<int> {4, 3, 8} }
        };
        List<int> arrCost = new List<int>();
        
        foreach(List<List<int>> item in magicSquares){
            int cost = 0;
            
            for(int i = 0; i < s.Count; i++){
                for(int j = 0; j < s[i].Count; j++){
                    cost += Math.Abs(item[i][j] - s[i][j]);
                }
            }
            arrCost.Add(cost);
        }
        
        
        return arrCost.Min();
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        List<List<int>> s = new List<List<int>>();

        for (int i = 0; i < 3; i++)
        {
            s.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(sTemp => Convert.ToInt32(sTemp)).ToList());
        }

        int result = Result.formingMagicSquare(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
