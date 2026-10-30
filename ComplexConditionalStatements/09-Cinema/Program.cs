string typeOfMovie = Console.ReadLine();
int row = int.Parse(Console.ReadLine());
int seat = int.Parse(Console.ReadLine());
int totalSeats = row * seat;

if (typeOfMovie == "Normal")
{
    Console.WriteLine($"{7.50 * totalSeats:F2}");
}
else if (typeOfMovie == "Premiere")
{
    Console.WriteLine($"{12.00 * totalSeats:F2}");
}
else if (typeOfMovie == "Discount")
{
    Console.WriteLine($"{5.00 * totalSeats:F2}");
}
