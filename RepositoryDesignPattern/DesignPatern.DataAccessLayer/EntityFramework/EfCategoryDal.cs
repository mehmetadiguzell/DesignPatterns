using DesignPatern.DataAccessLayer.Abstract;
using DesignPatern.DataAccessLayer.Concrete;
using DesignPatern.DataAccessLayer.Repository;
using DesignPatern.EntityLayer.Concrete;

namespace DesignPatern.DataAccessLayer.EntityFramework
{
    public class EfCategoryDal : GenericRepository<Category>, ICategoryDal
    {
        public EfCategoryDal(Context context) : base(context)
        {
        }
    }
}
