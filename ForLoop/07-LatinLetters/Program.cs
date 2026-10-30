char firstLetter = char.Parse(Console.ReadLine());
char secondLetter = char.Parse(Console.ReadLine());

for (char letter = firstLetter; letter <= secondLetter; letter++)
{
    Console.Write(letter + " ");
}