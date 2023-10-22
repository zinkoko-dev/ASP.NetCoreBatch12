using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDayTwo
{
    public interface ILoanOperation
    {
        void HomeLoan(decimal loanAmount, DateTime loanedDate);
        void SMELoan(string companyLicenceNo, decimal loanAmount, DateTime loanedDate);
        void VehicalLoan(decimal loanAmount, DateTime loanedDate);
        void LoanInstallment(decimal installmentAmount, string loanType);
    }
}
