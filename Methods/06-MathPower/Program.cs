int baseNumber = int.Parse(Console.ReadLine());
int power = int.Parse(Console.ReadLine());

CalculationBaseByPower(baseNumber, power);

static void CalculationBaseByPower (int baseNumber, int power)
{
    Console.WriteLine(Math.Pow(baseNumber, power));
}