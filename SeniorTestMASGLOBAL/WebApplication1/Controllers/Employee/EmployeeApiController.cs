namespace WebApplication1.Controllers.Employee
{
    using EmployeesInformation.BLL.EmployeeBLL;
    using EmployeesInformation.DAL.Models;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using System.Web.Http;

    public class EmployeeApiController : ApiController
    {
        private readonly IEmployeeBll _emloyeeBll;

        /// <inheritdoc />
        public EmployeeApiController(IEmployeeBll employeeBll)
        {
            this._emloyeeBll = employeeBll;
        }
        
        public async Task<IEnumerable<EmployeeModel>> Get()
        {
            return await _emloyeeBll.GetEmployees();
        }
        
        public async Task<IEnumerable<EmployeeModel>> Get(int id)
        {
            List<EmployeeModel> lstEmployees = new List<EmployeeModel>();
            var employee = await _emloyeeBll.GetEmployeeById(id);
            if (employee != null)
            {
                lstEmployees.Add(employee);
            }
            return lstEmployees;
        }
    }
}