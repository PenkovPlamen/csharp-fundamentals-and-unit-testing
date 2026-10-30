int width = int.Parse(Console.ReadLine());
int lenght = int.Parse(Console.ReadLine());

Console.WriteLine(RectangleArea(width, lenght));

static int RectangleArea(int width, int lenght)
{
    return width * lenght;
}