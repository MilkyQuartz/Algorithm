using System;
using System.Collections.Generic;
using System.IO;

public class P_19598
{
    static int N;
    static PriorityQueue<Time, int> pq;

    public static void Main(string[] args)
    {
        N = int.Parse(Console.ReadLine());
        pq = new PriorityQueue<Time, int>(Comparer<int>.Default);

        for (int i = 0; i < N; i++)
        {
            string[] input = Console.ReadLine().Split();
            pq.Enqueue(new Time(int.Parse(input[0]), true), int.Parse(input[0]));  // 시작시간
            pq.Enqueue(new Time(int.Parse(input[1]), false), int.Parse(input[1])); // 종료시간
        }

        int cnt = 0; // 회의실 개수
        int answer = 0; // 최대값

        while (pq.Count > 0)
        {
            Time t = pq.Dequeue();

            if (t.isStart)
            {
                cnt++;
                answer = Math.Max(cnt, answer);
            }
            else
            {
                cnt--;
            }
        }

        Console.Write(answer);
    }

    public class Time : IComparable<Time>
    {
        public int time;
        public bool isStart;

        public Time(int time, bool isStart)
        {
            this.time = time;
            this.isStart = isStart;
        }

        public int CompareTo(Time other)
        {
            return this.time - other.time;
        }
    }
}
