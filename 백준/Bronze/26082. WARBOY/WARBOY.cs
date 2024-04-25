string[] s = Console.ReadLine().Split();
int a = int.Parse(s[0]);
int b = int.Parse(s[1]);
int c = int.Parse(s[2]);

int result = (b / a * 3) * c;
Console.WriteLine(result);