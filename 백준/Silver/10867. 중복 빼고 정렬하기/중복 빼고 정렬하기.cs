StreamReader sr = new StreamReader(Console.OpenStandardInput());
StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

int n = int.Parse(sr.ReadLine());
int[] input = sr.ReadLine().Split().Select(int.Parse).ToArray();
input = input.OrderBy(x => x).Distinct().ToArray();

foreach (int i in input)
{
    sw.Write($"{i} ");
}

sw.Flush();
sw.Close();
sr.Close();