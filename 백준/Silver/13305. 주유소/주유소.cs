int N = Convert.ToInt32(Console.ReadLine());
long[] d = Array.ConvertAll(Console.ReadLine().Split(' '), long.Parse);
long[] won = Array.ConvertAll(Console.ReadLine().Split(' '), long.Parse);

long minWon = won[0];
long output = 0;

for (int i = 0; i < d.Length; i++)
{
    if (minWon < won[i])
    {
        output += minWon * d[i];
    }
    else
    {
        output += won[i] * d[i];
        minWon = won[i];
    }
}

Console.WriteLine(output);