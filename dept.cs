public class Debt
{
    public double balance;
    public double interestRate;

    public Debt(double initialBalance, double initialInterestRate)
    {
        balance = initialBalance;
        interestRate = initialInterestRate;
    }

    public void PrintBalance()
    {
        Console.WriteLine($"Баланс: {balance}");
    }

    public void WaitOneYear()
    {
        balance = balance * interestRate;
    }
}