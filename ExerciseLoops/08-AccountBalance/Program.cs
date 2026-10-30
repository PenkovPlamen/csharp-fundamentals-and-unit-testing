string input = Console.ReadLine();
double sum = 0;

while (input != "End")
{

    double money = double.Parse(input);

    if (money > 0)
    {
        sum += money;
        Console.WriteLine($"Increase: {money:F2}");
    }
    else if (money < 0)
    {
        sum -= Math.Abs(money);
        Console.WriteLine($"Decrease: {Math.Abs(money):F2}");
    }
    input = Console.ReadLine();
}

Console.WriteLine($"Balance: {sum:F2}");