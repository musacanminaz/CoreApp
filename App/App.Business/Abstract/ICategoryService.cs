using App.Entities.Concrete;
using System.Collections.Generic;

namespace App.Business.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll();

    }
}
