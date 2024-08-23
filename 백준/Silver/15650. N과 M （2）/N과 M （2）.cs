using System.Text;

StringBuilder sb = new StringBuilder();
int[] result;

string[] input = Console.ReadLine().Split();
int N = int.Parse(input[0]);
int M = int.Parse(input[1]);
result = new int[M];

dfs(N, M, 0, 1);
Console.Write(sb.ToString().TrimEnd());

void dfs(int N, int M, int cnt, int num)
{
    if (cnt == M)
    {
        for (int i = 0; i < M; i++)
        {
            sb.Append(result[i] + " ");
        }
        sb.AppendLine();
        return;
    }
    for (int i = num; i <= N; i++)
    {
        result[cnt] = i;
        dfs(N, M, cnt + 1, i + 1);
    }
}