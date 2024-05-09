using System;
using System.Collections.Generic;

class Program
{
    static double Ccw(double x1, double x2, double x3, double y1, double y2, double y3)
    {
        double res = x1 * y2 + x2 * y3 + x3 * y1;
        res += (-y1 * x2 - y2 * x3 - y3 * x1);
        return res / 2;
    }

    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        List<Tuple<double, double>> arr = new List<Tuple<double, double>>();

        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split();
            double x = double.Parse(input[0]);
            double y = double.Parse(input[1]);
            arr.Add(new Tuple<double, double>(x, y));
        }

        double res = 0;
        for (int i = 1; i < n; i++)
        {
            res += Ccw(arr[0].Item1, arr[i - 1].Item1, arr[i].Item1,
                       arr[0].Item2, arr[i - 1].Item2, arr[i].Item2);
        }

        Console.Write(Math.Abs(res).ToString("F1"));
    }
}