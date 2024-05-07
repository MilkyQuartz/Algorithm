string a = Console.ReadLine(); 
int n = int.Parse(Console.ReadLine());
int count = 0;

for (int i = 0; i < n; i++)
{
    string input = Console.ReadLine();
    if(input == a) count++;
}

Console.Write(count);