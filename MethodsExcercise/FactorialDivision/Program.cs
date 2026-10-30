int firstNumber = int.Parse(Console.ReadLine());
int secondNumber = int.Parse(Console.ReadLine());

int firstFactorial = Factorial(firstNumber);
int secondFactorial = Factorial(secondNumber);

int result = firstFactorial / secondFactorial;

Console.WriteLine(result);

static int Factorial (int number)
{
    int result = 1;

    for (int i = number; i >= 1; i--)
    {
        result *= i;
    }

    return result;
}
