using System.Text;

StringBuilder sb = new StringBuilder();

int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
    int[] reInput = input.OrderByDescending(x => x).ToArray();

    sb.AppendLine($"{reInput[2]}");
}

Console.Write(sb.ToString());