int input() => int.Parse(Console.ReadLine());

int n = input();
int[] array = new int[n];

for (int i = 0; i < n; i++)
{
    array[i] = input();
}

Array.Sort(array);

int max = 0;

for (int i = 0; i < n; i++)
{
    max = array[i] * (n - i) > max ? array[i] * (n - i) : max;
}

Console.Write(max);