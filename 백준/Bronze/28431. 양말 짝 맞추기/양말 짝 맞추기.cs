Dictionary<int, int> dict = new Dictionary<int, int>();

for(int i = 0; i < 5; i++)
{
    int n = int.Parse(Console.ReadLine());

    if (dict.ContainsKey(n))
    {
        dict.Remove(n);
    }
    else
    {
        dict.Add(n, 0);
    }
}

//foreach(var item in dict)
//{
//    Console.WriteLine(item.Key);
//}

Console.Write(dict.Keys.First());