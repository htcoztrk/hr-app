using System;
using System.Collections.Generic;
using System.Text;

namespace HR.Models.Entities
{
    public class EmployeeDepartment : Entities.Entity
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Role { get; set; }

        public Employee Employee { get; set; }
        public Department Department { get; set; }
    }
}
