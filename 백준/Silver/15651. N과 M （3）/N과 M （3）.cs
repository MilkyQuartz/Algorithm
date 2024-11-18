using System.Text;

int[] arr;
int N, M;
StringBuilder sb = new StringBuilder();

string[] input = Console.ReadLine().Split();
N = int.Parse(input[0]);
M = int.Parse(input[1]);

arr = new int[M];

Dfs(0);

Console.Write(sb.ToString());

void Dfs(int depth)
{
    if (depth == M)
    {
        for (int i = 0; i < M; i++)
        {
            sb.Append(arr[i] + " ");
        }
        sb.AppendLine();
        return;
    }

    for (int i = 1; i <= N; i++)
    {
        arr[depth] = i;
        Dfs(depth + 1);
    }
}