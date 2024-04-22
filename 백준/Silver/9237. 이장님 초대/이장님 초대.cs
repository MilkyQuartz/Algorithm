int n = int.Parse(Console.ReadLine());
int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
int[] day = new int[n];

Array.Sort(arr);
Array.Reverse(arr);

for (int i = 0; i < n; i++)
{
    day[i] = i + 1 + arr[i]; // 묘목 심는데 걸리는 시간 + 앞에 나무가 걸린시간
}

// 모든 나무가 자라야 하니 최대값을 구하고 자란 그 다음날 초대를 하니 +1을 해준다.

Console.Write(day.Max() + 1);