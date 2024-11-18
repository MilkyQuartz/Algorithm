int N = int.Parse(Console.ReadLine());
string[] result = DrawStars(N);
Console.WriteLine(string.Join("\n", result));

string[] DrawStars(int n)
{
    if (n == 1)
    {
        return new string[] { "*" };
    }

    string[] Stars = DrawStars(n / 3);
    string[] arr = new string[n];
    int index = 0;

    foreach (string star in Stars)
    {
        arr[index++] = star + star + star;
    }
    foreach (string star in Stars)
    {
        arr[index++] = star + new string(' ', n / 3) + star;
    }
    foreach (string star in Stars)
    {
        arr[index++] = star + star + star;
    }

    return arr;
}