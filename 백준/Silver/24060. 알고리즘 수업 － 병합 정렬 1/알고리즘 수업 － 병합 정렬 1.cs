using System;
using System.Collections.Generic;

class Program
{
    static List<int> MergeSort(List<int> arr)
    {
        if (arr.Count <= 1)
            return arr;

        int mid = (arr.Count + 1) / 2;
        List<int> lowArr = MergeSort(arr.GetRange(0, mid));
        List<int> highArr = MergeSort(arr.GetRange(mid, arr.Count - mid));

        List<int> sortedArr = new List<int>();
        int l = 0, h = 0;
        while (l < lowArr.Count && h < highArr.Count)
        {
            if (lowArr[l] <= highArr[h])
            {
                sortedArr.Add(lowArr[l]);
                ans.Add(lowArr[l]);
                l++;
            }
            else
            {
                sortedArr.Add(highArr[h]);
                ans.Add(highArr[h]);
                h++;
            }
        }

        while (l < lowArr.Count)
        {
            sortedArr.Add(lowArr[l]);
            ans.Add(lowArr[l]);
            l++;
        }

        while (h < highArr.Count)
        {
            sortedArr.Add(highArr[h]);
            ans.Add(highArr[h]);
            h++;
        }

        return sortedArr;
    }

    static List<int> ans = new List<int>();

    static void Main(string[] args)
    {
        string[] inputs = Console.ReadLine().Split();
        int N = int.Parse(inputs[0]);
        int K = int.Parse(inputs[1]);
        MergeSort(new List<int>(Array.ConvertAll(Console.ReadLine().Split(), int.Parse)));
        Console.WriteLine((K <= ans.Count) ? ans[K - 1].ToString() : "-1");
    }
}
