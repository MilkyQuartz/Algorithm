using System;
using static System.Console;

int n = int.Parse(ReadLine());
string[] s = new string[n];

s = ReadLine().Split();

int[] num = new int[n];

for (int i = 0; i < n; i++)
{
    num[i] = int.Parse(s[i]);
}

int v = int.Parse(ReadLine());

int count = 0;

foreach(int num2 in num)
{
    if(num2 == v)
    {
        count++;
    }
}

WriteLine(count);
