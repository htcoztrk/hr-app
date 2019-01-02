using HR.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace HR.Models.Entities
{
    public class Entity : IEntityBase
    {
        public int ID { get; set; }
    }
}
