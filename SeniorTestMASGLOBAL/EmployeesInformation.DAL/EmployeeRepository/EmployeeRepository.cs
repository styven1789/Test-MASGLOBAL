namespace EmployeesInformation.DAL.EmployeeRepository
{
    using System.Collections.Generic;
    using System.Configuration;
    using System.Linq;
    using System.Net.Http;
    using System.Threading.Tasks;
    using EmployeesInformation.DAL.Models;

    public class EmployeeRepository : IEmployeeRepository
    {
        public async Task<IEnumerable<EmployeeModel>> GetAll()
        {
            return await GetAllEmployeesFromService();
        }

        public async Task<EmployeeModel> GetById(int id)
        {
            var employees = await GetAllEmployeesFromService();
            return employees.FirstOrDefault(x => x.Id == id);
        }

        async Task<IEnumerable<EmployeeModel>> GetAllEmployeesFromService()
        {
            //Get path from Web.Config
            var path = ConfigurationManager.AppSettings["ServicePath"];
            var client = new HttpClient();
            var response = await client.GetAsync(path);
            var employees = await response.Content.ReadAsAsync<IEnumerable<EmployeeModel>>();
            return employees;
        }
    }
}
