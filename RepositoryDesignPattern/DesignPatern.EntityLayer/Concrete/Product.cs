namespace DesignPatern.EntityLayer.Concrete
{
    public class Product
    {
        public int ProductID { get; set; }
        public int ProductStock { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }

        public int CategoryID { get; set; }
        public Category Category { get; set; }
    }
}
