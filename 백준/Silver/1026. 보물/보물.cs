int n = int.Parse(Console.ReadLine());
int[] a = Console.ReadLine().Split().Select(int.Parse).ToArray();
int[] b = Console.ReadLine().Split().Select(int.Parse).ToArray();
int s = 0;

for (int i = 0; i < n; i++)
{
    int aMaxIndex = Array.IndexOf(a, a.Where((val, idx) => a[idx] != -1).Max());
    int bMinIndex = Array.IndexOf(b, b.Where((val, idx) => b[idx] != -1).Min());

    if (a[aMaxIndex] >= 0 && b[bMinIndex] >= 0)
    {
        s += a[aMaxIndex] * b[bMinIndex];

        a[aMaxIndex] = -1;
        b[bMinIndex] = -1;
    }
}

Console.Write(s);
