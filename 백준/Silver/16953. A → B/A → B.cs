string[] input = Console.ReadLine().Split();
int A = int.Parse(input[0]);
int B = int.Parse(input[1]);

int count = 1;

while (A != B)
{
    if (B < A)
    {
        Console.Write(-1);
        return;
    }
    if (B % 10 == 1)
    {
        B /= 10;
    }
    else if (B % 2 == 0)
    {
        B /= 2;
    }
    else
    {
        Console.Write(-1);
        return;
    }
    count++;
}
Console.Write(count);