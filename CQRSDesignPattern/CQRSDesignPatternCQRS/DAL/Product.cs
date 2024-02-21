﻿namespace CQRSDesignPatternCQRS.DAL
{
    public class Product
    {
        public int ProductID { get; set; }
        public int Stock { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public bool Status { get; set; }
    }
}
