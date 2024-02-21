using DesignPatern.BusinessLayer.Abstract;
using DesignPatern.DataAccessLayer.Abstract;
using DesignPatern.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatern.BusinessLayer.Concrete
{
    public class ProductManager : IProductService
    {
        private readonly IProductDal _productdal;

        public ProductManager(IProductDal productdal)
        {
            _productdal = productdal;
        }

        public void TDelete(Product t)
        {
            _productdal.Delete(t);
        }

        public Product TGetByID(int id)
        {
            return _productdal.GetByID(id);
        }

        public List<Product> TGetList()
        {
            return _productdal.GetList();
        }

        public void TInsert(Product t)
        {
            _productdal.Insert(t);
        }

        public List<Product> TProductListWithCategory()
        {
            return _productdal.ProductListWithCategory();
        }

        public void TUpdate(Product t)
        {
            _productdal.Update(t);
        }
    }
}
