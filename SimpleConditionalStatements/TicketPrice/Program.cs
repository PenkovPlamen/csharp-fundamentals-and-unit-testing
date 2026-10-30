string ticketType = Console.ReadLine();

double studentPrice = 1.00;
double regularPrice = 1.60;

if (ticketType == "student")
{
    Console.WriteLine($"${studentPrice:F2}");
}
else if (ticketType == "regular")
{
    Console.WriteLine($"${regularPrice:F2}");
}
else
{
    Console.WriteLine("Invalid ticket type!");
}