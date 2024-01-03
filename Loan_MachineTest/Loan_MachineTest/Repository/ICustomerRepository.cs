using Loan_MachineTest.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Loan_MachineTest.Repository
{

    public interface ICustomerRepository
    {
        Task<List<CustomerTbl>> GetAllCustomerTbl();

        Task<int> AddCustomer(CustomerTbl customer);

        Task UpdateCustomer(CustomerTbl customer);

        //Find an customer - Get customer by id

        Task<CustomerTbl> GetCustomerById(int? id);

        //Delete an customer
        Task<int> DeleteCustomer(int? id);
    }
}  

