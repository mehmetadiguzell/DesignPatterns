using DesignPatern.EntityLayer.Concrete;
using System.Collections.Generic;

namespace DesignPatern.BusinessLayer.Abstract
{
    public interface IProductService : IGenericService<Product>
    {
        List<Product> TProductListWithCategory();
    }
}
