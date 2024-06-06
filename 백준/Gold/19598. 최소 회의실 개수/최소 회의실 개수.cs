namespace ConsoleApp1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            StreamReader input = new StreamReader(
                new BufferedStream(Console.OpenStandardInput()));
            StreamWriter output = new StreamWriter(
                new BufferedStream(Console.OpenStandardOutput()));
            int n = int.Parse(input.ReadLine());
            PriorityQueue<int, int> pq = new();
            List<(int, int)> c = new();
            for (int i = 0; i < n; i++)
            {
                int[] temp = Array.ConvertAll(input.ReadLine().Split(' '), int.Parse);
                c.Add((temp[0], temp[1]));
            }
            c.Sort();
            pq.Enqueue(c[0].Item2, c[0].Item2);
            for (int i = 1; i < c.Count; i++)
            {
                if (c[i].Item1 < pq.Peek())
                {
                    pq.Enqueue(c[i].Item2, c[i].Item2);
                }
                else
                {
                    pq.Dequeue();
                    pq.Enqueue(c[i].Item2, c[i].Item2);
                }
            }

            output.Write(pq.Count);

            input.Close();
            output.Close();
        }
    }
}