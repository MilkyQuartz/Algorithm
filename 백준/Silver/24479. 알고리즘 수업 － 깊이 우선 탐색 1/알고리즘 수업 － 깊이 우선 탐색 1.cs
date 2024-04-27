using System;

namespace Baekjoon
{

    class Program
    {
        static StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        static StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        static int N, M, R;
        static List<int>[] graph;
        static int[] order;
        static bool[] visited;
        static int visitorder = 1;

        static void Main()
        {
            string[] inputs = sr.ReadLine().Split(" ");
            N = int.Parse(inputs[0]);
            M = int.Parse(inputs[1]);
            R = int.Parse(inputs[2]);

            graph = new List<int>[N + 1]; 
            for (int i = 0; i <= N; ++i)
            {
                graph[i] = new List<int>();
            }

            for (int i = 0; i < M; ++i)
            {
                inputs = sr.ReadLine().Split(" ");

                int u = int.Parse(inputs[0]);
                int v = int.Parse(inputs[1]);
                graph[u].Add(v);
                graph[v].Add(u);
            }

            for (int i = 1; i <= N; ++i)
            {
                graph[i].Sort();
            }

            order = new int[N + 1];
            visited = new bool[N + 1];
            dfs(R);

            for (int i = 1; i <= N; ++i)
            {
                sw.WriteLine(order[i]);
            }

            sr.Close();
            sw.Close();

        }

        static void dfs(int node)
        {
            if (visited[node])
            {
                return;
            }

            visited[node] = true;

            order[node] = visitorder;
            ++visitorder;

            foreach (int next in graph[node])
            {
                if (visited[next] == false)
                {
                    dfs(next);
                }
            }
        }

    }
}