using System.Collections.Generic;
using App.Entities.Concrete;

namespace App.Web.Models
{
    public class CategoryListViewModel
    {
        public List<Category> Categories { get; set; }
        public int CurrentCategory { get; internal set; }
    }
}