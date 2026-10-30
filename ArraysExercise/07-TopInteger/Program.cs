int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

for (int i = 0; i < numbers.Length; i++)
{
    bool biggestInteger = true;

    for (int j = i + 1; j < numbers.Length; j++)
    {
        if (numbers[i] <= numbers[j])
        {
            biggestInteger = false;
            break;
        }
    }
    if (biggestInteger)
    {
        Console.Write(numbers[i] + " ");
    }
}