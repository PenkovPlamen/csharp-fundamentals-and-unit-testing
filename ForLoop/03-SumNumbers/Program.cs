int countOfNumbers = int.Parse(Console.ReadLine());
double sum = 0;

for (int i = 1; i <= countOfNumbers; i++)
{
    double floatingPointNumbers = double.Parse(Console.ReadLine());
    sum += floatingPointNumbers;
}
Console.WriteLine(sum);
