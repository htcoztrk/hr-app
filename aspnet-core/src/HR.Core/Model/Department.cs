using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstBProject.Model
{
    class Department:Entity
    {
        //attributes
        public string Name { get; set; }
        //Navigation
        public ICollection <EmployeeDepartment> EmployeeDepartments { get; set; }
        public Company Company { get; set; }
    }

}
