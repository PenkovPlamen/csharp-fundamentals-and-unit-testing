int numberOfCommands = int.Parse(Console.ReadLine());
List<string> guests = new List<string>();

string command = " ";

for (int i = 0; i < numberOfCommands; i++)
{
    command = Console.ReadLine();
    string name = command.Split(" ")[0];

    if (command.EndsWith("not going!"))
    {
        if (guests.Contains(name))
        {
            guests.Remove(name);
        }
        else
        {
            Console.WriteLine($"{name} is not in the list!");
        }
    }
    else if (command.EndsWith("going!"))
    {
        if (!guests.Contains(name))
        {
            guests.Add(name);
        }
        else
        {
            Console.WriteLine($"{name} is already in the list!");
        }
    }
}
foreach (string guest in guests)
{
    Console.WriteLine(guest);
}