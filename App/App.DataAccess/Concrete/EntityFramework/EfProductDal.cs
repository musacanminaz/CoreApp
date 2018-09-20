using System;
using System.Collections.Generic;
using System.Text;
using App.Core.DataAccess.EntityFramework;
using App.Entities.Concrete;

namespace App.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal: EfEntityRepositoryBase<Product, AppContext>
    {
    }
}
