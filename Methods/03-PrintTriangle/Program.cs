int number = int.Parse(Console.ReadLine());

PrintTriangle(number);

static void PrintTriangle(int number)
{
    for (int row = 1; row <= number; row++)
    {
        for (int column = 1; column <= row; column++)
        {
            Console.Write(column + " ");
        }
        Console.WriteLine();
    }
    for (int decreasingRow = number - 1; decreasingRow >= 1; decreasingRow--)
    {
        for (int decreasingColumn = 1; decreasingColumn <= decreasingRow; decreasingColumn++)
        {
            Console.Write(decreasingColumn + " ");
        }
        Console.WriteLine();
    }
}