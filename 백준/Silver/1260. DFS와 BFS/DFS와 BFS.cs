using System;
using System.Collections.Generic;

class Graph
{
    public int V; // public으로 변경
    public List<int>[] adj; // public으로 변경

    public Graph(int v)
    {
        V = v;
        adj = new List<int>[V + 1];
        for (int i = 1; i <= V; i++)
        {
            adj[i] = new List<int>();
        }
    }

    public void AddEdge(int u, int v)
    {
        adj[u].Add(v);
        adj[v].Add(u); // 양방향 그래프이므로 반대 방향도 추가
    }

    public void DFS(int v)
    {
        bool[] visited = new bool[V + 1];
        DFSUtil(v, visited);
    }

    private void DFSUtil(int v, bool[] visited)
    {
        visited[v] = true;
        Console.Write(v + " ");

        foreach (int u in adj[v])
        {
            if (!visited[u])
            {
                DFSUtil(u, visited);
            }
        }
    }

    public void BFS(int v)
    {
        bool[] visited = new bool[V + 1];
        Queue<int> queue = new Queue<int>();

        visited[v] = true;
        queue.Enqueue(v);

        while (queue.Count != 0)
        {
            v = queue.Dequeue();
            Console.Write(v + " ");

            foreach (int u in adj[v])
            {
                if (!visited[u])
                {
                    visited[u] = true;
                    queue.Enqueue(u);
                }
            }
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split();
        int N = int.Parse(input[0]);
        int M = int.Parse(input[1]);
        int V = int.Parse(input[2]);

        Graph graph = new Graph(N);

        for (int i = 0; i < M; i++)
        {
            string[] edge = Console.ReadLine().Split();
            int u = int.Parse(edge[0]);
            int v = int.Parse(edge[1]);
            graph.AddEdge(u, v);
        }

        for (int i = 1; i <= N; i++)
        {
            graph.adj[i].Sort(); // 인접 리스트를 정렬하여 작은 번호의 노드부터 방문하도록 함
        }

        graph.DFS(V);
        Console.WriteLine();

        graph.BFS(V);
    }
}
