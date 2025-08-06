using System;
using System.Collections.Generic;

namespace OOPProject
{
    // MODEL
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    // INTERFACE
    public interface IEmployeeService
    {
        void AddEmployee(Employee emp);
        void DisplayEmployees();
    }

    // SERVICE
    public class EmployeeService : IEmployeeService
    {
        private List<Employee> employees = new();

        public void AddEmployee(Employee emp)
        {
            employees.Add(emp);
        }

        public void DisplayEmployees()
        {
            foreach (var emp in employees)
            {
                Console.WriteLine($"ID: {emp.Id}, Name: {emp.Name}");
            }
        }
    }

    // PROGRAM ENTRY POINT
    class Program
    {
        static void Main(string[] args)
        {
            IEmployeeService employeeService = new EmployeeService();

            employeeService.AddEmployee(new Employee { Id = 1, Name = "Suman" });
            employeeService.AddEmployee(new Employee { Id = 2, Name = "Neha" });

            employeeService.DisplayEmployees();
        }
    }
}
