﻿using App.Core.DataAccess.EntityFramework;
using App.DataAccess.Abstract;
using App.Entities.Concrete;

namespace App.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal: EfEntityRepositoryBase<Product, AppContext>, IProductDal
    {
    }
}
