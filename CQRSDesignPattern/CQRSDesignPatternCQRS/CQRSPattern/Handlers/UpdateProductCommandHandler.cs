using CQRSDesignPatternCQRS.CQRSPattern.Comment;
using CQRSDesignPatternCQRS.DAL;

namespace CQRSDesignPatternCQRS.CQRSPattern.Handlers
{
    public class UpdateProductCommandHandler
    {
        private readonly Context _context;
        public UpdateProductCommandHandler(Context context)
        {
            _context = context;
        }

        public void Handle(UpdateProductCommand commandHandler)
        {
            var values = _context.Products.Find(commandHandler.ProductID);
            values.Name = commandHandler.Name;
            values.Price = commandHandler.Price;
            values.Status = true;
            values.Stock=commandHandler.Stock;
            values.Description=commandHandler.Description;
            _context.SaveChanges();

        }
    }
}
