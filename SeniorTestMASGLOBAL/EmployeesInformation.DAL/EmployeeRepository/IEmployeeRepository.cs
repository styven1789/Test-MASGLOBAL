namespace EmployeesInformation.DAL.EmployeeRepository
{
    using EmployeesInformation.DAL.Models;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IEmployeeRepository
    {
        Task<IEnumerable<EmployeeModel>> GetAll();
        Task<EmployeeModel> GetById(int id);
    }
}
