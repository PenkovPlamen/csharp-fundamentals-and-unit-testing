int firstNumber = int.Parse(Console.ReadLine());
int secondNumber = int.Parse(Console.ReadLine());
int thirdNumber = int.Parse(Console.ReadLine());
int fourthNumber = int.Parse(Console.ReadLine());
int fifthNumber = int.Parse(Console.ReadLine());

int biggestNumber = firstNumber;

if(secondNumber > biggestNumber)
{
    biggestNumber = secondNumber;
}
if (thirdNumber > biggestNumber)
{
    biggestNumber = thirdNumber;
}
if (fourthNumber > biggestNumber)
{
    biggestNumber = fourthNumber;
}
if (fifthNumber > biggestNumber)
{
    biggestNumber = fifthNumber;
}
Console.WriteLine(biggestNumber);