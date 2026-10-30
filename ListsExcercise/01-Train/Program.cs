List<int> wagons = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
int capacity = int.Parse(Console.ReadLine());

string input = Console.ReadLine();

while (input != "end")
{
    if (input.StartsWith("Add"))
    {
        int passengers = int.Parse(input.Split(" ")[1]);
        wagons.Add(passengers);
    }
    else
    {
        int passengers = int.Parse(input);
        for (int i = 0; i < wagons.Count; i++)
        {
            if (wagons[i] + passengers <= capacity)
            {
                wagons[i] += passengers;
                break;
            }
        }
    }

    input = Console.ReadLine();
}

Console.WriteLine(string.Join(" ", wagons));