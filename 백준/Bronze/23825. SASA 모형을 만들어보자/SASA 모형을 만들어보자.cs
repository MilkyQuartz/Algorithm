string[] input = Console.ReadLine().Split();
int n = int.Parse(input[0]);
int m = int.Parse(input[1]);

int result = Math.Min(n/2, m/2);

Console.Write(result);