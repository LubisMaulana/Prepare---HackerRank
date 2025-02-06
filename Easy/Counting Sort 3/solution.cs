using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        List<int> arr = new List<int>();
        
        int n = int.Parse(Console.ReadLine());
        for(int i = 0; i < n; i++){
            string input = Console.ReadLine();
            List<string> arrInput = input.Split(" ").ToList();
            int x = int.Parse(arrInput[0]);
            arr.Add(x);
        }
        
        List<int> result = Result.countingSort(arr);
        
        Console.WriteLine($"{String.Join(" ", result)}");
    }
}

class Result{
    public static List<int> countingSort(List<int> arr){
        List<int> result = new List<int>(new int[100]);
        
        for(int i = 0; i < arr.Count; i++){
            result[arr[i]]++;
        }
        
        for(int i = 1; i < result.Count; i++){
            result[i]+=result[i-1];
        }
        
        return result;
    }
}
