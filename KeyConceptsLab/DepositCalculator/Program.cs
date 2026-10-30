double depositAmount = double.Parse(Console.ReadLine());
int termOfDeposit = int.Parse(Console.ReadLine());
double annualInterestRate = double.Parse(Console.ReadLine());
double Amount = depositAmount + termOfDeposit * (depositAmount * (annualInterestRate / 100)) / 12;
Console.WriteLine(Amount);