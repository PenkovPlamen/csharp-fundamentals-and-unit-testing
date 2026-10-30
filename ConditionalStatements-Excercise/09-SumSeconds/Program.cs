int firstNumber = int.Parse(Console.ReadLine());
int secondNumber = int.Parse(Console.ReadLine());
int thirdNumber = int.Parse(Console.ReadLine());

int totalSeconds = firstNumber + secondNumber + thirdNumber;

Console.WriteLine($"{totalSeconds / 60}:{totalSeconds % 60:D2}");