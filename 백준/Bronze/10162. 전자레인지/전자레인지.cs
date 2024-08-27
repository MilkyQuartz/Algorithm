StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

int n = int.Parse(sr.ReadLine());
int a = 300;
int b = 60;
int c = 10;
int aCount = 0, bCount = 0, cCount = 0;

aCount = n / a;
n = n % a;
bCount = (n % a) / b;
n = n % b;
cCount = (n % b) / c;
n = n % c;

if (n == 0)
{
    sw.Write($"{aCount} {bCount} {cCount}");
}
else
{
    sw.Write(-1);
}

sw.Flush();
sw.Close();
sr.Close();