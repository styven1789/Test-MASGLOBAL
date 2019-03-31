namespace SeniorTestMASGLOBAL.Tests.Employee
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using EmployeesInformation.BLL.EmployeeBLL;
    using EmployeesInformation.DAL.EmployeeRepository;
    using EmployeesInformation.DAL.Models;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public async Task TestSalary()
        {
            IEnumerable<EmployeeModel> lstEmployee = new List<EmployeeModel>()
            {
                new EmployeeModel()
                {

                    Id = 3,
                    Name = "Estivenson",
                    RoleID = 1,
                    RoleName = "Administrator",
                    ContractTypeName = "HourlySalaryEmployee",
                    HourlySalary = 30000,
                    MonthlySalary = 50000

                },
                new EmployeeModel()
                {

                    Id = 4,
                    Name = "Juliana",
                    RoleID = 2,
                    RoleName = "Contractor",
                    ContractTypeName = "MonthlySalaryEmployee",
                    HourlySalary = 30000,
                    MonthlySalary = 50000

                }
            };

            //Arrange
            decimal expectedAnualSalary1 = 4320000;
            decimal expectedAnualSalary2 = 600000;

            //Act
            IEmployeeRepository employeeRepository = new EmployeeRepository();
            
            EmployeeBll objEmployeeBll = new EmployeeBll(employeeRepository);

            var employees = await objEmployeeBll.GetEmployees();

            List<EmployeeModel> lstEmployees = employees.ToList();

            //Assert
            Assert.AreEqual(lstEmployees.ElementAt(0).YearSalary, expectedAnualSalary1);
            Assert.AreEqual(lstEmployees.ElementAt(1).YearSalary, expectedAnualSalary2);
        }
    }
}
