namespace OOPDayTwo
{
    public class BankAccount : BankOperations, IATMOperation
    {
		private string accountNumber;

		public string AccountNumber
		{
			get { return accountNumber; }
			set { accountNumber = value; }
		}
		public string AccountName { get;set; }
		public decimal OpeningBalance { get; set; }

        public void ShowInfo()
		{
			Console.WriteLine("Bank Account Information");
			Console.WriteLine("Account Number : " + AccountNumber);
			Console.WriteLine("Account Name : "+ AccountName);
		}

        public override void Deposit(BankAccount bankAccount, decimal amount)
        {
            CheckValidAmount(amount);

            if (bankAccount.AccountNumber.Equals(this.AccountNumber)) 
            {
                this.OpeningBalance += amount;
                Console.WriteLine("Deposit Successful !!");
            }
        }

        public override void Transfer(BankAccount fromBankAccount, BankAccount toBankAccount, decimal transferAmount)
        {
            CheckValidAmount(transferAmount);

            if (transferAmount > fromBankAccount.OpeningBalance)
            {
                Console.WriteLine("You cannot enough money to transfer" + " Current amount is " + fromBankAccount.OpeningBalance);
            }
            else
            {
                toBankAccount.OpeningBalance += transferAmount;
                Console.WriteLine("Transfer Successful to " + toBankAccount);
                fromBankAccount.OpeningBalance -= transferAmount;
            }
        }

        public override void Withdraw(BankAccount bankAccount, decimal amount)
        {
            CheckValidAmount(amount);

            if (amount > bankAccount.OpeningBalance)
            {
                Console.WriteLine("You cannot enough money" + " Current amount is " + bankAccount.OpeningBalance);
            }
            else
            {
                bankAccount.OpeningBalance -= amount;
                Console.WriteLine("Withdraw Successful !!");
                Console.WriteLine("Current amount is "+ bankAccount.OpeningBalance);
            }
        }

        public override void CheckBalance()
        {
            Console.WriteLine("Current balance is " + this.OpeningBalance);
        }

        private void CheckValidAmount(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Invalid amount");
            }
        }

        public void Topup(string phoneNumber, decimal amount)
        {
            if (amount>this.OpeningBalance)
            {
                Console.WriteLine("You cannot enough money");
            }
            else if(!string.IsNullOrEmpty(phoneNumber))
            {
                Console.WriteLine($"{phoneNumber} is topup successfully with {amount} kyats");
                this.OpeningBalance -= amount;
            }
        }
    }
}