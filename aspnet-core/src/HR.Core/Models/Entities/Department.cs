using System;
using System.Collections.Generic;
using System.Text;

namespace HR.Models.Entities
{
    public class Department : Entities.Entity
    {
        public string Name { get; set; }

        //Navigation 
        public ICollection<EmployeeDepartment> Employees { get; set; }
        public Company Company { get; set; }
    }
}
