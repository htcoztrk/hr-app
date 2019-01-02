using System;
using System.Collections.Generic;
using System.Text;

namespace HR.Models.Entities
{
    public class Employee : Entities.Entity
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        //Navigation 
        public ICollection<EmployeeDepartment> Departments { get; set; }

        public void Hire(DateTime Start,DateTime End,string Role)
        {

        }
        public void Fire(int id)
        {

        }

    }
}
