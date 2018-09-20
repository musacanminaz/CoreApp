using App.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Entities.Concrete
{
    public class Category:IEntity
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public bool IsActive { get; set; }
        public bool IsDelete { get; set; }
    }
}
