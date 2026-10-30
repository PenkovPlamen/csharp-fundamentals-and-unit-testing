int n = int.Parse(Console.ReadLine());

int number = 1;

for (int row = 1; row <= n; row++)
{
    for (int column = 1; column <= row; column++)
    {
        Console.Write($"{number} ");
        number++;
        if (number > n)
        {
            break;
        }
    }
    Console.WriteLine();
    if (number > n)
    {
        break;
    }
}

