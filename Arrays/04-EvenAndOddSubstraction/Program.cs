int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

int sumOfEvenNumbers = 0;
int sumOfOddNumbers = 0;

foreach (int number in numbers)
{
    if (number % 2 == 0)
    {
        sumOfEvenNumbers += number;
    }
    else
    {
        sumOfOddNumbers += number;
    }
}

int finalResult = sumOfEvenNumbers - sumOfOddNumbers;
Console.WriteLine(finalResult);