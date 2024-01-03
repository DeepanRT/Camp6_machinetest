using Loan_MachineTest.Models;

namespace Loan_MachineTest.Repository
{
    public interface ILoginRepository
    {
        public LoginTbl UserValidation(string userName, string password);
    }
}
