class Program
{
    static int n;
    static int[,] graph;
    static List<int> num = new List<int>();
    static int[] dx = { 0, 0, 1, -1 };
    static int[] dy = { 1, -1, 0, 0 };
    static int count = 0;

    static bool DFS(int x, int y)
    {
        if (x < 0 || x >= n || y < 0 || y >= n)
        {
            return false;
        }

        if (graph[x, y] == 1)
        {
            count += 1;
            graph[x, y] = 0;
            for (int i = 0; i < 4; i++)
            {
                int nx = x + dx[i];
                int ny = y + dy[i];
                DFS(nx, ny);
            }
            return true;
        }
        return false;
    }

    static void Main(string[] args)
    {
        StreamReader sr = new StreamReader(Console.OpenStandardInput());
        StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

        n = int.Parse(sr.ReadLine());
        graph = new int[n, n];

        for (int i = 0; i < n; i++)
        {
            string input = sr.ReadLine();
            for (int j = 0; j < n; j++)
            {
                graph[i, j] = input[j] - '0';
            }
        }

        int result = 0;

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (DFS(i, j))
                {
                    num.Add(count);
                    result += 1;
                    count = 0;
                }
            }
        }

        num.Sort();
        sw.WriteLine(result);
        foreach (int number in num)
        {
            sw.WriteLine(number);
        }

        sw.Flush();
        sw.Close();
        sr.Close();
    }
}
