class Program
{
    static int[] dx = { 0, 0, 1, -1 };
    static int[] dy = { 1, -1, 0, 0 };

    static int BFS(int[,] graph, int a, int b)
    {
        int n = graph.GetLength(0);
        LinkedList<Tuple<int, int>> group = new LinkedList<Tuple<int, int>>();
        group.AddLast(new Tuple<int, int>(a, b));
        graph[a, b] = 0;
        int count = 1;

        while (group.Count > 0)
        {
            var node = group.First;
            var (x, y) = node.Value;
            group.RemoveFirst();
            for (int i = 0; i < 4; i++)
            {
                int nx = x + dx[i];
                int ny = y + dy[i];
                if (nx < 0 || nx >= n || ny < 0 || ny >= n)
                {
                    continue;
                }
                if (graph[nx, ny] == 1)
                {
                    graph[nx, ny] = 0;
                    group.AddLast(new Tuple<int, int>(nx, ny));
                    count += 1;
                }
            }
        }
        return count;
    }

    static void Main(string[] args)
    {
        StreamReader sr = new StreamReader(Console.OpenStandardInput());
        StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

        int n = int.Parse(sr.ReadLine());
        int[,] graph = new int[n, n];

        for (int i = 0; i < n; i++)
        {
            string input = sr.ReadLine();
            for (int j = 0; j < n; j++)
            {
                graph[i, j] = input[j] - '0';
            }
        }

        List<int> cnt = new List<int>();
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (graph[i, j] == 1)
                {
                    cnt.Add(BFS(graph, i, j));
                }
            }
        }

        cnt.Sort();
        sw.WriteLine(cnt.Count);
        foreach (int count in cnt)
        {
            sw.WriteLine(count);
        }

        sw.Flush();
        sw.Close();
        sr.Close();
    }
}
