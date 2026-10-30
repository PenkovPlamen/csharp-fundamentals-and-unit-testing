double firstNumber = double.Parse(Console.ReadLine());
double secondNumber = double.Parse(Console.ReadLine());
string operation = Console.ReadLine();

if (operation == "+")
{
    Console.WriteLine($"{firstNumber} + {secondNumber} = {firstNumber + secondNumber:F2}");
}
else if (operation == "-")
{
    Console.WriteLine($"{firstNumber} - {secondNumber} = {firstNumber - secondNumber:F2}");
}
else if (operation == "*")
{
    Console.WriteLine($"{firstNumber} * {secondNumber} = {firstNumber * secondNumber:F2}");
}
else if (operation == "/")
{
    if (secondNumber == 0)
    {
        Console.WriteLine("Cannot divide by zero.");
    }
    else
    {
        Console.WriteLine($"{firstNumber} / {secondNumber} = {firstNumber / secondNumber:F2}");
    }
}
else
{
    Console.WriteLine("Invalid operation.");
}