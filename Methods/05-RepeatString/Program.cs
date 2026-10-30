string text = Console.ReadLine();
int count = int.Parse(Console.ReadLine());

Console.WriteLine(RepeatString(text, count));

static string RepeatString (string text, int count)
{
    string newText = "";

    for (int i = 0; i < count; i++)
        newText += text;
    return newText;
}