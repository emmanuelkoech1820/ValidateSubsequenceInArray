using System;
using System.Collections.Generic;

namespace ValidateSubsequenceInArray
{
  //  Given two non-empty arrays of integers, write a function that determines
  //whether the second array is a subsequence of the first one.
    class Program
    {
        static void Main(string[] args)
        {
            List<int> arr1 = new List<int>{ 2, 3, 4, 5 };
            List<int> arr2 = new List<int> { 2, 5 };

            IsSubsequence(arr1, arr2);
        }

        private static bool IsSubsequence(List<int> arr1, List<int> arr2)
        {
            int arr1Index = 0;
            int arr2Index = 0;
            List<int> list = new List<int>();
            while (arr1Index < arr1.Count && arr2Index< arr2.Count)
            {
                var id = arr1[arr1Index];
                var id2 = arr2[arr2Index];
                if (id == id2)
                {
                    arr2Index ++;
                    list.Add(id2);
                }
                arr1Index++;
            }
            return arr2Index == arr2.Count;

        }
    }
}
