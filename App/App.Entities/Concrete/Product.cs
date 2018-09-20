﻿using App.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Entities.Concrete
{
    public class Product:IEntity
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public short UnitsInStock { get; set; }
        public bool IsActive { get; set; }
        public bool IsDelete { get; set; }

    }
}
