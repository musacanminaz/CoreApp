using System;
using System.Collections.Generic;
using System.Text;

namespace App.Core.Entities
{
    public interface IEntity
    {
        bool IsActive { get; set; }
        bool IsDelete { get; set; }
    }
}
