namespace BankEncapsulation;

public class Bank_Account
{
    private double _balance;

    public void Deposit(double deposit)
    {
        _balance += deposit;
    }

    public double GetBalance()
    {
        return _balance;
    }
}