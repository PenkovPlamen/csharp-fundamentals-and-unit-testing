int number = int.Parse(Console.ReadLine());
int originalNumber = number;
bool isSpecial = true;

while (number > 0)
{
   int lastDigit = number % 10;
    if (originalNumber % lastDigit !=0)
    {
        isSpecial = false;
        break;
    }
    number /= 10;
}
if (isSpecial)
{
    Console.WriteLine($"{originalNumber} is special");
}
else
{
    Console.WriteLine($"{originalNumber} is not special");
}