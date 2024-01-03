using Loan_MachineTest.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Loan_MachineTest.Repository
{
    public interface ILoanDetailsRepository
    {
        
            Task<List<LoanDetailsTbl>> GetAllLoanDetails();

            Task<int> AddDetails(LoanDetailsTbl loanDetails);

            Task UpdateDetails(LoanDetailsTbl loanDetails);

            //Find an Details - Get Details by id

            Task<LoanDetailsTbl> GetDetailsById(int? id);

            //Delete an Details
            Task<int> DeleteDetails(int? id);
        
    }
}
