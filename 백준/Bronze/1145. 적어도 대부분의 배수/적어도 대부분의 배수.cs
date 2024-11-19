int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
int min = input.Min();

while (true)
{
    int count = 0; 

    for (int i = 0; i < input.Length; i++)
    {
        if (min % input[i] == 0)
        {
            count++;
        }
    }
    if (count >= 3) 
    {
        break;
    }
    min++;
}

Console.WriteLine(min);