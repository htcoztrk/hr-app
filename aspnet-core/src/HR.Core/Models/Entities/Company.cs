using System;
using System.Collections.Generic;
using System.Text;

namespace HR.Models.Entities
{
    public class Company : Entities.Entity
    {
        public string Name { get; set; }

        //Navigation
        public ICollection<Department> Departments { get; set; }
    }
}
