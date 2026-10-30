string season = Console.ReadLine();
string accommodationType = Console.ReadLine();
int days = int.Parse(Console.ReadLine());

if (season == "Spring")
{
    if(accommodationType == "Hotel")
    {
        Console.WriteLine($"{days * 30 - (days * 30 * 0.2):F2}");
    }
    else
    {
        Console.WriteLine($"{days * 10 - (days * 10 * 0.2):F2}");
    }
}
else if (season == "Summer")
{
    if (accommodationType == "Hotel")
    {
        Console.WriteLine($"{days * 50:F2}");
    }
    else
    {
        Console.WriteLine($"{days * 30:F2}");
    }
}
else if (season == "Autumn")
{
    if (accommodationType == "Hotel")
    {
        Console.WriteLine($"{days * 20 - (days * 20 * 0.3):F2}");
    }
    else
    {
        Console.WriteLine($"{days * 15 - (days * 15 * 0.3):F2}");
    }
}
else if (season == "Winter")
{
    if (accommodationType == "Hotel")
    {
        Console.WriteLine($"{days * 40 - (days * 40 * 0.1):F2}");
    }
    else
    {
        Console.WriteLine($"{days * 10 - (days * 10 * 0.1):F2}");
    }
}