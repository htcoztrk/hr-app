using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstBProject.Model
{
    class Employee:Entity
    {
        //Attributes
        public string Name { get; set; }
        public string Surname { get; set; }
       
        //Methods
        public void Hire()
        {

        }
        public void Fire(int ID)
        {
            this.Id = ID;
        }
      
        //Navigation
        public ICollection<EmployeeDepartment> EmployeeDepartments { get; set; }
    }

}
