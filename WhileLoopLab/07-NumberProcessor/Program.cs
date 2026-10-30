int initialNumber = int.Parse(Console.ReadLine());

while (true)
{
    string operation = Console.ReadLine();
    if (operation == "Inc")
    {
        initialNumber++;
    }
    if (operation == "Dec")
    {
        initialNumber--;
    }
    if (operation == "End")
    {
        Console.WriteLine(initialNumber);
        break;
    }
}

// lecturer's solution

int number = int.Parse(Console.ReadLine());
string command = Console.ReadLine();
while (command != "End")
{
    switch (command)
    {
        case "Inc": number++; break;
        case "Dec": number--; break;
    }
    command = Console.ReadLine();
}
Console.WriteLine(number);