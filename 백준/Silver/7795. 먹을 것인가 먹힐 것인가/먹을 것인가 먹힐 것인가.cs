using System;
using System.Linq;

class Program
{
    static int CountPairs(int[] A, int[] B)
    {
        Array.Sort(A);
        Array.Sort(B);
        int count = 0;
        int aIndex = 0;

        foreach (var b in B)
        {
            while (aIndex < A.Length && A[aIndex] <= b)
            {
                aIndex++;
            }
            count += A.Length - aIndex;
        }
        return count;
    }

    static void Main(string[] args)
    {
        int T = int.Parse(Console.ReadLine());
        for (int t = 0; t < T; t++)
        {
            string[] sizes = Console.ReadLine().Split();
            int N = int.Parse(sizes[0]);
            int M = int.Parse(sizes[1]);
            int[] A = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] B = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int result = CountPairs(A, B);
            Console.WriteLine(result);
        }
    }
}
