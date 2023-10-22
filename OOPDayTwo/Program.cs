using OOPDayTwo;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Banking System");

        BankAccount account1 = new BankAccount()
        {
            AccountName = "U Mg Mg",
            AccountNumber = "1234567890",
            OpeningBalance = 5000000,
        };
        Console.Write("Account One Balance : ");
        account1.CheckBalance();

        BankAccount account2 = new BankAccount()
        {
            AccountName = "Daw Su Su",
            AccountNumber = "0987654321",
            OpeningBalance = 6000000,
        };
        Console.Write("Account Two Balance : ");
        account2.CheckBalance();

        Customer c1 = new Customer()
        {
            Name = "Mg Mg",
            Nrc = "14/DHG(N)2342245",
            PhoneNumber = "123456789",
            Address = "YGN"
        };
        c1.BankAccount = account1;

        //c1.BankAccount.Deposit(c1.BankAccount, 200000);
        //c1.BankAccount.CheckBalance();

        Customer c2 = new Customer()
        {
            Name = "Su Su",
            Nrc = "14/DHG(N)2342245",
            PhoneNumber = "1234567890",
            Address = "MDY"
        };
        c2.BankAccount = account2;

        c2.BankAccount.Topup("091234567", 1000);
        c2.BankAccount.CheckBalance();

        c2.BankAccount.Deposit(c2.BankAccount, 100000);
        c2.BankAccount.CheckBalance();

        account1.Transfer(account1, c2.BankAccount, 100000);
        account1.CheckBalance();

        ILoanOperation loanOperation = new LoanOperationService(c2.BankAccount);
        loanOperation.HomeLoan(100000, DateTime.Now);
        loanOperation.LoanInstallment(100000, "homeloan");
        c2.BankAccount.CheckBalance();
    }
}