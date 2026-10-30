int stopNumber = int.Parse(Console.ReadLine());
int previousNumber = 0;

while (previousNumber != stopNumber)
{
    int number = int.Parse(Console.ReadLine());

    if (number == stopNumber)
    {
        double result = previousNumber * 1.2;
        Console.WriteLine(result);
    }
    previousNumber = number;
}
