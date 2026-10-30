int firstNumber = int.Parse(Console.ReadLine());
int secondNumber = int.Parse(Console.ReadLine());
int thirdNumber = int.Parse(Console.ReadLine());

if (firstNumber < secondNumber + thirdNumber && secondNumber <firstNumber + thirdNumber && thirdNumber < firstNumber + secondNumber)
{
    Console.WriteLine("Valid Triangle");
}
else
{
    Console.WriteLine("Invalid Triangle");
}