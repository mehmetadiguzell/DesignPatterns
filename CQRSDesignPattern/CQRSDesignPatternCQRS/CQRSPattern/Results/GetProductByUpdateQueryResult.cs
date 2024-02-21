namespace CQRSDesignPatternCQRS.CQRSPattern.Results
{
    public class GetProductByUpdateQueryResult
    {
        public int ProductID { get; set; }
        public int Stock { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }
}
