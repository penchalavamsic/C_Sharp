using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Injection

{
    //class for data members
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
    }
    public interface IEmployeeDAL
    {
        List<Employee> SelectAllEmployees();
    }
    public class EmployeeDAL : IEmployeeDAL
    {
        public List<Employee> SelectAllEmployees()
        {
            List<Employee> ListEmployees = new List<Employee>
            {
                new Employee() { ID = 1, Name = "Pranaya", Department = "IT" },
                new Employee() { ID = 2, Name = "Kumar", Department = "HR" },
                new Employee() { ID = 3, Name = "Rout", Department = "Payroll" }
            };
            return ListEmployees;
        }
    }
    public class EmployeeBL
    {
        private readonly IEmployeeDAL _employeeDAL;

        // Constructor Injection ✅
        public EmployeeBL(IEmployeeDAL employeeDAL) //dependency injection
        {
            _employeeDAL = employeeDAL;
        }

        public void ShowAllEmployees()
        {
            List<Employee> employees = _employeeDAL.SelectAllEmployees();

            foreach (var emp in employees)
            {
                Console.WriteLine($"ID: {emp.ID}, Name: {emp.Name}, Department: {emp.Department}");
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            IEmployeeDAL employeeDAL = new EmployeeDAL();
            EmployeeBL employeeBL = new EmployeeBL(employeeDAL);

            employeeBL.ShowAllEmployees();

            Console.ReadLine();
        }
    }
}
