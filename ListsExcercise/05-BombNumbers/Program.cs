List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

int[] bombInfo = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
int bombNumber = bombInfo[0];
int bombPower = bombInfo[1];

int sum = 0;

for (int i = 0; i < numbers.Count; i++)
{
    if (numbers[i] == bombNumber)
    {
        int startIndex = Math.Max(0, i - bombPower);
        int endIndex = Math.Min(i + bombPower, numbers.Count - 1);

        numbers.RemoveRange(startIndex, endIndex - startIndex + 1);

        i = startIndex - 1;
    }
}
foreach (int number  in numbers)
{
    sum+=number;
}
Console.WriteLine(sum);