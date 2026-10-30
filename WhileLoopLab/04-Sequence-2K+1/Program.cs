// solution with while loop
int maxNumber = int.Parse(Console.ReadLine());
int i = 1;

while (i <= maxNumber)
{
    Console.WriteLine(i);
    i = i * 2 + 1;
}
// solution with for loop
int maxNumber = int.Parse(Console.ReadLine());

for (int i = 1; i <= maxNumber; i++)
{
    Console.WriteLine(i);
    i = i * 2;
}