using App.Core.DataAccess.EntityFramework;
using App.Entities.Concrete;

namespace App.DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category, AppContext>
    {
    }
}
