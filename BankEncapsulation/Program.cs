namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            var bankAccount = new Bank_Account();
            
            Console.WriteLine("Your current balance is $343.54. How much would you like to deposit?");
            double.TryParse(Console.ReadLine(), out double balance);
            bankAccount.Deposit(balance + 343.54);
            
            balance =  bankAccount.GetBalance();
            Console.WriteLine($"Your new balance is: ${balance}");
        }
    }
}
