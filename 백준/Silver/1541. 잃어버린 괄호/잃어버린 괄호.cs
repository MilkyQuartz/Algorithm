using System;
using System.Linq;

string n = Console.ReadLine();
string[] m = n.Split('-');

int answer = 0;

int x = m[0].Split('+').Select(int.Parse).Sum();
if (n[0] == '-')
{
    answer -= x;
}
else
{
    answer += x;
}

for (int i = 1; i < m.Length; i++)
{
    x = m[i].Split('+').Select(int.Parse).Sum();
    answer -= x;
}

Console.Write(answer);