List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
string command = Console.ReadLine();

while (command != "End")
{
    if(command.StartsWith("Add"))
    {
        int numberToAdd = int.Parse(command.Split(" ")[1]);
        numbers.Add(numberToAdd);
    }
    else if (command.StartsWith("Insert"))
    {
        int numberToInsert = int.Parse(command.Split(" ")[1]);
        int indexToInsert = int.Parse(command.Split(" ")[2]);

        if (indexToInsert < 0 || indexToInsert >= numbers.Count)
        {
            Console.WriteLine("Invalid index");
            command = Console.ReadLine();
            continue;
        }

        numbers.Insert(indexToInsert, numberToInsert);
    }
    else if (command.StartsWith("Remove"))
    {

        int indexToRemove = int.Parse(command.Split(" ")[1]);

        if (indexToRemove < 0 || indexToRemove >= numbers.Count)
        {
            Console.WriteLine("Invalid index");
            command = Console.ReadLine();
            continue;
        }

        numbers.RemoveAt(indexToRemove);
    }
    else if (command.StartsWith("Shift left"))
    {
        int count = int.Parse(command.Split(" ")[2]);

        for (int i = 0; i < count; i++)
        {
            int firstNumber = numbers[0];
            
            for (int j = 0; j < numbers.Count - 1; j++)
            {
                numbers[j] = numbers[j + 1];
            }

            numbers[numbers.Count - 1] = firstNumber;
        }
    }
    else if (command.StartsWith("Shift right"))
    {
        int count = int.Parse(command.Split(" ")[2]);

        for (int i = 0; i < count; i++)
        {
            int lastNumber = numbers[numbers.Count - 1];

            for (int j = numbers.Count - 1; j > 0; j--)
            {
                numbers[j] = numbers[j - 1];
            }
            numbers[0] = lastNumber;
        }
    }

    command = Console.ReadLine();
}
Console.WriteLine(string.Join(" ", numbers));