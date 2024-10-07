int n, m, cabbage;
bool[,] a = new bool[51, 51];
bool[,] check = new bool[51, 51];
int[] dx = { 0, 0, 1, -1 };
int[] dy = { 1, -1, 0, 0 };

int TC = int.Parse(Console.ReadLine());
for (int i = 0; i < TC; i++)
{
    string[] inputs = Console.ReadLine().Split();
    m = int.Parse(inputs[0]);
    n = int.Parse(inputs[1]);
    cabbage = int.Parse(inputs[2]);

    // 배열 초기화
    Array.Clear(a, 0, a.Length);
    Array.Clear(check, 0, check.Length);

    for (int j = 0; j < cabbage; j++)
    {
        inputs = Console.ReadLine().Split();
        int x = int.Parse(inputs[0]);
        int y = int.Parse(inputs[1]);
        a[y, x] = true; // 1. 행 - y축, 열 - x축
    }

    int bug_count = 0;

    for (int j = 0; j < n; j++)
    {
        for (int k = 0; k < m; k++)
        {
            if (a[j, k] && !check[j, k])
            {
                if (Dfs(j, k)) bug_count++;
            }
        }
    }

    Console.WriteLine(bug_count);
}

bool Dfs(int y, int x)
{
    if (check[y, x]) return false;
    check[y, x] = true;

    for (int i = 0; i < 4; i++)
    {
        int next_x = x + dx[i];
        int next_y = y + dy[i];

        if (next_x >= 0 && next_y >= 0 && next_x < m && next_y < n && a[next_y, next_x])
            Dfs(next_y, next_x);
    }
    return true;
}