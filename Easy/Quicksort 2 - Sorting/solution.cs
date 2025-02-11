using System;
using System.Collections.Generic;
using System.IO;
class Solution {
static int partition(ref int[] arr, int low, int high){
    int pivot = arr[low];

    for(int i = low + 1; i <= high; i++){
        if(arr[i] < pivot){
            int temp = arr[i];
            int index = Array.IndexOf(arr, pivot);
            arr = arr.Where((val, idx) => idx != i).ToArray();
            
            List<int> result = new List<int>();
            result.AddRange(arr[..index]);
            result.Add(temp);
            result.AddRange(arr[index..]);
            
            arr = result.ToArray();
        }
    }

    return Array.IndexOf(arr, pivot);
}

static void quickSort(ref int[] arr, int low, int high){
    if(low < high){
        int pivotIndex = partition(ref arr, low, high);
        quickSort(ref arr, low, pivotIndex - 1);
        quickSort(ref arr, pivotIndex + 1, high);
        
        Console.WriteLine(String.Join(" ", arr[low..(high+1)]));
    }
}

static void quickSort(int[] ar) {
    quickSort(ref ar, 0, ar.Length - 1);
}

/* Tail starts here */
    static void Main(String[] args) {
           
           int _ar_size;
           _ar_size = Convert.ToInt32(Console.ReadLine());
           int [] _ar =new int [_ar_size];
           String elements = Console.ReadLine();
           String[] split_elements = elements.Split(' ');
           for(int _ar_i=0; _ar_i < _ar_size; _ar_i++) {
                  _ar[_ar_i] = Convert.ToInt32(split_elements[_ar_i]); 
           }

           quickSort(_ar);
    }
}