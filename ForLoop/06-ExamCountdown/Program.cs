int days = int.Parse(Console.ReadLine());

for (int i = days; i >= 1; i--)
{
    if (i >= 1)
    {
        Console.WriteLine($"{i} days before the exam");
    }
}
Console.WriteLine("The exam has come");