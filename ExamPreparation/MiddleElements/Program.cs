int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

int firstNumber = numbers.Length / 2;
int secondNumber = firstNumber - 1;

double sum = (numbers[firstNumber] + numbers[secondNumber]) / 2.0;

Console.WriteLine($"{sum:F2}");