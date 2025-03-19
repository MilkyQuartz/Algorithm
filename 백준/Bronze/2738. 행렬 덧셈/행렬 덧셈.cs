string[] s = Console.ReadLine().Split();
int n = int.Parse(s[0]);
int m = int.Parse(s[1]);

int[,] arr1 = new int[n, m];
int[,] arr2 = new int[n, m];
int[,] arr3 = new int[n, m];

for (int i = 0; i < n; i++)
{
    string[] row = Console.ReadLine().Split();
    for (int j = 0; j < m; j++)
    {
        arr1[i,j] = int.Parse(row[j]);
    }
}

for (int i = 0; i < n; i++)
{
    string[] row = Console.ReadLine().Split();
    for (int j = 0; j < m; j++)
    {
        arr2[i, j] = int.Parse(row[j]);
    }
}
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        arr3[i, j] = arr1[i,j] + arr2[i, j];
        Console.Write(arr3[i, j] + " ");
    }
    Console.WriteLine();
}