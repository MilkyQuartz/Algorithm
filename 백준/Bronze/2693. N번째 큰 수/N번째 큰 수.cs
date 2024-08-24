using System.Text;

StringBuilder sb = new StringBuilder();

int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
    Array.Sort(input);

    sb.AppendLine($"{input[input.Length-3]}");
}

Console.Write(sb.ToString());