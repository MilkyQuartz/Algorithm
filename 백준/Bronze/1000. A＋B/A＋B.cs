using System;
using static System.Console;

namespace TestWorld
{
    internal class MainApp
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split();

            Console.WriteLine(int.Parse(s[0]) + int.Parse(s[1]));
        }
    }
}