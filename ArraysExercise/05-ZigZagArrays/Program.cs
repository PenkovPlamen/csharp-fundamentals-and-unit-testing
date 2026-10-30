int number = int.Parse(Console.ReadLine());

int[] firstArray = new int[number];
int[] secondArray = new int[number];

for (int i = 0; i < number; i++)
{
    int[] currentNumbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

    if (i % 2 == 0)
    {
        firstArray[i] = currentNumbers[0];
        secondArray[i] = currentNumbers[1];
    }
    else
    {
        secondArray[i] = currentNumbers[0];
        firstArray[i] = currentNumbers[1];
    }
}
Console.WriteLine(string.Join(" ", firstArray));
Console.WriteLine(string.Join(" ", secondArray));