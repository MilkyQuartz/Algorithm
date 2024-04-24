int k = int.Parse(Console.ReadLine());
string[] d = Console.ReadLine().Split();
int d1 = Math.Max(int.Parse(d[0]), int.Parse(d[1]));
int d2 = Math.Min(int.Parse(d[0]), int.Parse(d[1]));
double result = 0;

if(d1 == d2) // 윗변=아랫변일시 직사각형or정사각형.. 높이 = 빗변k이므로 그냥 k제곱해주면됨
{
    result = (int)Math.Pow(k, 2);
}
else
{
    result = Math.Pow(k, 2) - Math.Pow((d1 - d2) / 2.0, 2); // 피타고라스 공식
}

Console.Write(result);