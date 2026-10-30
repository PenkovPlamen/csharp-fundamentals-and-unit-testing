string type = Console.ReadLine();

if (type == "int")
{
    int firstValue = int.Parse(Console.ReadLine());
    int secondValue = int.Parse(Console.ReadLine());

    Console.WriteLine(GreaterIntValue(firstValue, secondValue));
}
else if (type == "char")
{
    char firstValue = char.Parse(Console.ReadLine());
    char secondValue = char.Parse(Console.ReadLine());

    Console.WriteLine(GreaterCharValue(firstValue, secondValue));
}
else
{
    string firstValue = Console.ReadLine();
    string secondValue = Console.ReadLine();

    Console.WriteLine(GreaterStringValue(firstValue, secondValue));
}

static int GreaterIntValue (int firstValue, int secondValue)
{
    if (firstValue > secondValue)
    {
        return firstValue;
    }
    else
    {
        return secondValue;
    }
}
static char GreaterCharValue(char firstValue, char secondValue)
{
    if (firstValue > secondValue)
    {
        return firstValue;
    }
    else
    {
        return secondValue;
    }
}
static string GreaterStringValue(string firstValue, string secondValue)
{
    if (string.Compare(firstValue, secondValue) > 0)
    {
        return firstValue;
    }
    return secondValue;
}