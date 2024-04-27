using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static int[] visited;
    static List<List<int>> graph;
    static List<int> queue = new List<int>();
    static int visitCount = 0;

    static void Main(string[] args)
    {
        StreamReader sr = new StreamReader(Console.OpenStandardInput());
        StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

        string[] input = Console.ReadLine().Split();
        int n = int.Parse(input[0]);
        int m = int.Parse(input[1]);
        int r = int.Parse(input[2]);

        visited = new int[n + 1];
        graph = new List<List<int>>();

        for (int i = 0; i < n + 1; i++) graph.Add(new List<int>());

        for(int i = 0;i < m; i++)
        {
            input = Console.ReadLine().Split();
            int u = int.Parse(input[0]);
            int v = int.Parse(input[1]);
            graph[u].Add(v);
            graph[v].Add(u);
        }

        for (int i = 1; i < graph.Count; i++)
        {
            graph[i].Sort();
            graph[i].Reverse();
        }
        BFS(r);


        for(int i = 1; i < visited.Length ; i++)
        {
            sw.WriteLine(visited[i]);
        }
        sw.Flush();
        sw.Close();
        sr.Close();
    }

    static void BFS(int R)
    {
        visited[R] = ++visitCount;
        Enqueue(R);

        while(queue.Count != 0)
        {
            int u = Dequeue();
            foreach(int v in graph[u])
            {
                if (visited[v] == 0)
                {
                    visited[v] = ++visitCount;
                    Enqueue(v);
                }
            }
        }

    }

    static void Enqueue(int v)
    {
        queue.Add(v);
    }

    static int Dequeue()
    {
        int v = queue[0];
        queue.RemoveAt(0);
        return v;
    }
}
