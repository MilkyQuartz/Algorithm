using System;
using System.Collections.Generic;
using System.IO;

public class MainClass
{
    public static void Main(string[] args)
    {
        using (var reader = new StreamReader(Console.OpenStandardInput()))
        {
            int T = int.Parse(reader.ReadLine());

            for (int i = 0; i < T; i++)
            {
                Stack<int> stack = new Stack<int>();

                string[] input = reader.ReadLine().Split(' ');
                int N = int.Parse(input[0]);
                int M = int.Parse(input[1]);

                bool[] visited = new bool[N + 1];
                List<int>[] link = new List<int>[N + 1];
                for (int j = 1; j <= N; j++) link[j] = new List<int>();

                for (int j = 0; j < M; j++)
                {
                    input = reader.ReadLine().Split(' ');
                    int u = int.Parse(input[0]);
                    int v = int.Parse(input[1]);
                    link[u].Add(v);
                    link[v].Add(u);
                }

                // 시작 국가를 스택에 넣는다.
                stack.Push(1);
                int count = 0;

                while (stack.Count > 0)
                {
                    // 현재 방문한 국가를 스택에서 꺼내고 방문처리
                    int now = stack.Pop();

                    visited[now] = true;

                    foreach (int next in link[now])
                    {
                        // 현재 국가와의 비행 노선이 존재하는데 아직 방문하지 않은 국가라면 스택에 넣는다.
                        if (!visited[next])
                        {
                            visited[next] = true;
                            count++;
                            stack.Push(next);
                        }
                    }
                }

                Console.WriteLine(count);
            }
        }
    }
}
