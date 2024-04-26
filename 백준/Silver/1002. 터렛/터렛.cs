using System.Text;

StringBuilder sb = new StringBuilder();
int t = int.Parse(Console.ReadLine());

for (int i = 0; i < t; i++)
{
    string[] s = Console.ReadLine().Split();
    var x1 = int.Parse(s[0]);
    var y1 = int.Parse(s[1]);
    var r1 = int.Parse(s[2]);
    var x2 = int.Parse(s[3]);
    var y2 = int.Parse(s[4]);
    var r2 = int.Parse(s[5]);

    var distance = Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2);
    var sumR = Math.Pow(r1 + r2, 2);
    var differR = Math.Pow(r1 - r2, 2);

    if (distance == 0)
    {
        if (r1 == r2) sb.AppendLine("-1");
        else sb.AppendLine("0");
    }
    else if (distance == sumR || distance == differR)
    {
        sb.AppendLine("1");
    }
    else if(distance < sumR && distance > differR)
    {
        sb.AppendLine("2");
    }
    else sb.AppendLine("0");
}

Console.Write(sb.ToString());