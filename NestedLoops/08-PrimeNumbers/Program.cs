int startingRange = int.Parse(Console.ReadLine());
int endingRange = int.Parse(Console.ReadLine());

for (int i = startingRange; i <= endingRange; i++)
{

    int divisors = 0;
   
  for (int j = startingRange + 1; j <= endingRange ; j++)
    {
        if (i % j == 0)
        {
            divisors++;

            if (divisors > 2)
            {
                break;
            }
        }
    }
    if (divisors == 2)
    {
        Console.Write($"{i} ");
    }
}