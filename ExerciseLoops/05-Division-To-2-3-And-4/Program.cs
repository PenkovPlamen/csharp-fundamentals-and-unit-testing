int n = int.Parse(Console.ReadLine());
int dividedBy2 = 0;
int dividedBy3 = 0;
int dividedBy4 = 0;

for (int i = 1; i <= n; i++)
{ 
    int number = int.Parse(Console.ReadLine());

    if (number % 2 == 0)
    { 
        dividedBy2++;
    }
    if (number % 3 == 0)
    {
        dividedBy3++;
    }
    if (number % 4 == 0)
    {
        dividedBy4++;
    }
}

double percentDividedBy2 = dividedBy2 / (n * 0.01);                    
double percentDividedBy3 = dividedBy3 / (n * 0.01);
double percentDividedBy4 = dividedBy4 / (n * 0.01);

Console.WriteLine($"{percentDividedBy2:F2}%");
Console.WriteLine($"{percentDividedBy3:F2}%");
Console.WriteLine($"{percentDividedBy4:F2}%");