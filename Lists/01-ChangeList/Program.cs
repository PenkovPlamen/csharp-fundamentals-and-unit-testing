List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

string command = Console.ReadLine();

while (command != "end")
{
    if (command.StartsWith("Delete"))
    {
       int numberToDelete = int.Parse(command.Split(" ")[1]);

       numbers.RemoveAll(n => n == numberToDelete);
    }
    else if (command.StartsWith("Insert"))
    {
        int numberToInsert = int.Parse(command.Split(" ")[1]);
        int index = int.Parse(command.Split(" ")[2]);
        numbers.Insert(index, numberToInsert);
    }

    command = Console.ReadLine();
}
Console.WriteLine(string.Join(" ", numbers));