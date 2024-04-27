StreamReader sr = new StreamReader(Console.OpenStandardInput());
StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

string[] input = sr.ReadLine().Split();
int N = int.Parse(input[0]);
int M = int.Parse(input[1]);
int R = int.Parse(input[2]);

// 각 정점의 방문 여부를 저장하는 배열
bool[] visited = new bool[N + 1];
// 각 정점의 방문 순서를 저장하는 배열
int[] order = new int[N + 1];
// 각 정점의 인접 정점 리스트를 저장하는 리스트 배열
List<int>[] graph = new List<int>[N + 1];

for (int i = 1; i <= N; i++)
{
    graph[i] = new List<int>();
}

for (int i = 0; i < M; i++)
{
    string[] edge = sr.ReadLine().Split();
    int u = int.Parse(edge[0]);
    int v = int.Parse(edge[1]);
    graph[u].Add(v);
    graph[v].Add(u);
}

int count = 1;

DFS(graph, R, visited, order, ref count);

for (int i = 1; i <= N; i++)
{
    sw.WriteLine(visited[i] ? order[i] : 0);
}

sw.Flush();
sw.Close();
sr.Close();

void DFS(List<int>[] graph, int v, bool[] visited, int[] order, ref int count)
{
    visited[v] = true;
    order[v] = count++;

    // 인접 정점을 오름차순으로 방문
    foreach (int u in graph[v].OrderBy(x => x))
    {
        if (!visited[u])
        {
            DFS(graph, u, visited, order, ref count);
        }
    }
}