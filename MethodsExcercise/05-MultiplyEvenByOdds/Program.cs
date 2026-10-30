int number = int.Parse(Console.ReadLine());

Console.WriteLine(GetMultipleOfEvenAndOdds(number));

static int GetSumOfEvenDigits(int number)
{
    number = Math.Abs(number);
    int sumOfEvenDigits = 0;
    
    while (number > 0)
    {
        int digit = number % 10;
        
        if (digit % 2 == 0)
        {
            sumOfEvenDigits += digit;
        }
        number /= 10;
    }
    return sumOfEvenDigits;
}

static int GetSumOfOddDigits(int number)
{
    number = Math.Abs(number);
    int sumOfOddDigits = 0;

    while (number > 0)
    {
        int digit = number % 10;

        if (digit % 2 != 0)
        {
            sumOfOddDigits += digit;
        }
        number /= 10;
    }
    return sumOfOddDigits;
}

static int GetMultipleOfEvenAndOdds(int number)
{
    return GetSumOfEvenDigits(number) * GetSumOfOddDigits(number);
}