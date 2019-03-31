namespace EmployeesInformation.BLL.EmployeeBLL
{
    using EmployeesInformation.DAL.Models;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IEmployeeBll
    {
        Task<IEnumerable<EmployeeModel>> GetEmployees();
        Task<EmployeeModel> GetEmployeeById(int id);
    }
}
