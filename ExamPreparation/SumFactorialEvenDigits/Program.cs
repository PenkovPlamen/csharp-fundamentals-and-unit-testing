int number = int.Parse(Console.ReadLine());

int sum = 0;


while(number > 0)
{
    
    int lastDigit = number % 10;

    if (lastDigit % 2 == 0)
    {
        int factorialSum = 1;
        for (int j = lastDigit; j >= 1; j--)
        {
            factorialSum *= j;
        }
        sum += factorialSum;
    }
    number /= 10;
}

Console.WriteLine(sum);