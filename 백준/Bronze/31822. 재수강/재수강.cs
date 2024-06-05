string input = Console.ReadLine();
input = input.Substring(0, 5);
int n = int.Parse(Console.ReadLine());
int count = 0;

for (int i = 0; i < n; i++)
{
    string input2 = Console.ReadLine();
    input2 = input2.Substring(0, 5);

    if(input2 == input) count++;
}

Console.Write(count);