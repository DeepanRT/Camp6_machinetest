using Loan_MachineTest.Models;
using System.Linq;

namespace Loan_MachineTest.Repository
{
    public class LoginRepository
    {

        #region Find user by Credentials

        private readonly LoanMS_dbContext _context;

        public LoginRepository(LoanMS_dbContext context)
        {
            _context = context;
        }

        public LoginTbl UserValidation(string un, string pwd)
        {
            if (_context != null)
            {
                /*CustomerTbl user = _context.CustomerTbl.FirstOrDefault(u => u.Username == un && u.Password == pwd);
                if (user != null)
                {
                    return user;
                }*/
            }
            return null;
        }

        #endregion
    }
}
