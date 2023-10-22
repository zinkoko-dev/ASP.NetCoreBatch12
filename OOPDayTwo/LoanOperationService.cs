using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDayTwo
{
    public class LoanOperationService : ILoanOperation
    {
        private readonly BankAccount _bankAccount;

        //Contructor (cto 2tab)
        public LoanOperationService(BankAccount bankAccount)
        {
            this._bankAccount = bankAccount;
        }

        public void HomeLoan(decimal loanAmount, DateTime loanedDate)
        {
            Console.WriteLine("Home Lone is successfully");
            Console.WriteLine("You Lone at " + loanedDate);
        }

        public void SMELoan(string companyLicenceNo, decimal loanAmount, DateTime loanedDate)
        {
            if (!string.IsNullOrEmpty(companyLicenceNo)) 
            {
                Console.WriteLine("SMELoand is successful for this company licence");
                Console.WriteLine("You loan at " + loanedDate);
            }
        }

        public void VehicalLoan(decimal loanAmount, DateTime loanedDate)
        {
            Console.WriteLine("VehicalLoan is successfully");
            Console.WriteLine("You Lone at " + loanedDate);
        }

        public void LoanInstallment(decimal installmentAmount, string loanType)
        {
            if (loanType.Equals("homeloan"))
            {
                Console.WriteLine("Home lone is installment is paid with amount " + installmentAmount);
                _bankAccount.OpeningBalance -= installmentAmount;
            }
        }
    }
}