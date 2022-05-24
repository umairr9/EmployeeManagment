using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagment.Models
{
    public class MockEmployeeRepository : iEmployeeRepository
    {
        private List<Employee> _employeeList;



        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>()
            {
                new Employee() { Id=1, Name="Umairrr", Department="HR", Email="umair@gmail.com"},
                new Employee() {Id=2, Name="Khan", Department="Eng", Email="khan@gmail.com"},
                new Employee() {Id=3, Name="Haider", Department="Admin", Email="khan123@gmail.com"}
            };
        }

        public IEnumerable<Employee> GetAllEmployee()
        {
            return _employeeList;
        }

        public Employee GetEmployee(int Id)
        {
            return _employeeList.FirstOrDefault(e => e.Id == Id);
        }
    }
}
