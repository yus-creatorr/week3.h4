public class Account
{
     public string name;
     double balance;

    public Account(string name, double balance)
    {
        this.name = name;
        this.balance = balance;
    }
    public void Withdraw(double amount)
    {
        balance -= amount;
    }

    public void Deposit(double amount)
    {
        balance += amount;
    }

    public override string ToString()
    {
        return balance.ToString();
    }
}