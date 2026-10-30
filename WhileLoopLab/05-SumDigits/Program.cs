int i = int.Parse(Console.ReadLine());
int sum = 0;

while (i > 0)
{
    sum += i % 10;
    i /= 10;
}
Console.WriteLine(sum);
