int n = int.Parse(Console.ReadLine());
int count = n / 5;

while (count >= 0)
{
    int result = n - (count * 5);
    if(result % 3 == 0)
    {
        count += result / 3;
        Console.Write(count);
        return;
    }
    else
    {
        count--;
    }
}

Console.Write("-1");