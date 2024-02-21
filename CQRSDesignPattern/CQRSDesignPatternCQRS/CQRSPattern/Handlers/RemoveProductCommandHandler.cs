using CQRSDesignPatternCQRS.CQRSPattern.Comment;
using CQRSDesignPatternCQRS.CQRSPattern.Queries;
using CQRSDesignPatternCQRS.CQRSPattern.Results;
using CQRSDesignPatternCQRS.DAL;

namespace CQRSDesignPatternCQRS.CQRSPattern.Handlers
{
    public class RemoveProductCommandHandler
    {
        private readonly Context _context;

        public RemoveProductCommandHandler(Context context)
        {
            _context = context;
        }

        public void Handle(RemoveProductCommand command)
        {
            var values = _context.Set<Product>().Find(command.Id);
            _context.Remove(values);
            _context.SaveChanges();
        }
    }
}
