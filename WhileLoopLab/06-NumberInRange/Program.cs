// lecturer's solution
int i = int.Parse(Console.ReadLine());

while (i < 1 || i > 100)
{
    i = int.Parse(Console.ReadLine());

}
Console.WriteLine(i);

// my solution 

int i = int.Parse(Console.ReadLine());

while(i < 1 || i > 100)
{
    i = int.Parse(Console.ReadLine());
    while(i >= 1 && i <= 100)
    {
        Console.WriteLine(i);
        break;
    }
}