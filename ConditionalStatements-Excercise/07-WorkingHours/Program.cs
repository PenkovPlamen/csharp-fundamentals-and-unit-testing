int hours = int.Parse(Console.ReadLine());
string day = Console.ReadLine();

if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday" || day == "Saturday")
{
    if (hours >= 10 && hours <= 18)
    {
        Console.WriteLine("open");
    }
    else
    {
        Console.WriteLine("closed");
    }

}
else
{
    Console.WriteLine("closed");
}