int firstNumber = int.Parse(Console.ReadLine());
int secondNumber = int.Parse(Console.ReadLine());
int thirdNumber = int.Parse(Console.ReadLine());

ProductValue(firstNumber, secondNumber, thirdNumber);

static void ProductValue(int firstNumber, int secondNumber, int thirdNumber)
{
    if ((firstNumber > 0 && secondNumber > 0 && thirdNumber > 0) || (firstNumber < 0 && secondNumber < 0 && thirdNumber > 0) || (firstNumber < 0 && secondNumber > 0 && thirdNumber < 0) || (firstNumber > 0 && secondNumber < 0 && thirdNumber < 0))
    {
        Console.WriteLine("positive");
    }
    else if (firstNumber == 0 || secondNumber == 0 || thirdNumber == 0)
    {
        Console.WriteLine("zero");
    }
    else
    {
        Console.WriteLine("negative");
    }
}