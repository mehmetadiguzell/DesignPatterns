using DesignPatern.EntityLayer.Concrete;
using System.Collections.Generic;

namespace DesignPatern.DataAccessLayer.Abstract
{
    public interface IProductDal: IGenericDal<Product>
    {
        List<Product> ProductListWithCategory();
    }
}
