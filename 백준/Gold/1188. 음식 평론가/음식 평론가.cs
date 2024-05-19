string[] inputs = Console.ReadLine().Split();
int N = int.Parse(inputs[0]);
int M = int.Parse(inputs[1]);

Console.WriteLine(M - Gcd(N, M));

static int Gcd(int a, int b)
{
    if (a % b == 0)
        return b;
    return Gcd(b, a % b);
}