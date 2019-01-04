using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstBProject.Model
{
    class EmployeeDepartment:Entity
    {
        public DateTime startDate { get; set; }
        public 
        //Navigation
        public Employee Employees { get; set; }
        public Department Departments { get; set; }
    }
}
