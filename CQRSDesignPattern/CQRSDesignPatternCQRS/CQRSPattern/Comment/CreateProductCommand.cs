namespace CQRSDesignPatternCQRS.CQRSPattern.Comment
{
    public class CreateProductCommand
    {
        public int Stock { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public bool Status { get; set; }
    }
}
