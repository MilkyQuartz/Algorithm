using System;

class Program
{
    static int N;
    static string result;
    static bool finish = false;

    static void Solve(string tmp, int cnt)
    {
        if (finish) return;
        int size = tmp.Length;
        for (int i = 1; i <= size / 2; i++)
        {
            if (tmp.Substring(size - i, i) == tmp.Substring(size - 2 * i, i)) return;
        }
        if (cnt == N)
        {
            result = tmp;
            finish = true;
        }
        for (int i = 0; i < N; i++)
        {
            Solve(tmp + "1", cnt + 1);
            Solve(tmp + "2", cnt + 1);
            Solve(tmp + "3", cnt + 1);
        }
    }

    static void Main(string[] args)
    {
        N = int.Parse(Console.ReadLine());
        Solve("", 0);
        Console.WriteLine(result);
    }
}