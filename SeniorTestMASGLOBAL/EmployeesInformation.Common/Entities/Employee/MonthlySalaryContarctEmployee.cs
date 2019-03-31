namespace EmployeesInformation.Common.Entities.Employee
{
    public class MonthlySalaryContarctEmployee : Employee
    {
        public MonthlySalaryContarctEmployee(decimal salary) : base(salary)
        {
        }

        public override void GetSalary(decimal salary)
        {
            Salary = salary * 12;
        }
    }
}
