string password = Console.ReadLine();

ValidatePassword(password);

static void ValidatePassword(string password)
{
    bool isValid = true;

    if (password.Length < 6 || password.Length > 10)
    {
        Console.WriteLine("Password must be between 6 and 10 characters");
        isValid = false;
    }

    int digitCount = 0;
    bool isLetterOrADigit = true;

    for(int i = 0; i < password.Length; i++)
    {
        if (password[i] >= '0' && password[i] <= '9')
        {
            digitCount++;
        }
        if (!((password[i] >= 'a' && password[i] <= 'z') || (password[i] >= 'A' && password[i] <= 'Z') || (password[i] >= '0' && password[i] <= '9')))
        {
            isLetterOrADigit = false;
        }
    }
    if (!isLetterOrADigit)
    {
        Console.WriteLine("Password must consist only of letters and digits");
        isValid = false;
    }
    if (digitCount < 2)
    {
        Console.WriteLine("Password must have at least 2 digits");
        isValid = false;
    }
    if(isValid)
    {
        Console.WriteLine("Password is valid");
    }
}