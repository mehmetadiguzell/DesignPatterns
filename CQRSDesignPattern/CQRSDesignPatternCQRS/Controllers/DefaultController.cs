using CQRSDesignPatternCQRS.CQRSPattern.Comment;
using CQRSDesignPatternCQRS.CQRSPattern.Handlers;
using CQRSDesignPatternCQRS.CQRSPattern.Queries;
using Microsoft.AspNetCore.Mvc;

namespace CQRSDesignPatternCQRS.Controllers
{
    public class DefaultController : Controller
    {
        private readonly GetProductQueryHandler _getProductQueryHandler;
        private readonly CreateProductCommandHandler _createProductCommandHandler;
        private readonly GetProductByIDQueryHandler _getProductByIDQueryHandler;
        private readonly RemoveProductCommandHandler _removeProductCommandHandler;
        private readonly GetProductUpdateByIdQueryHandler _getProductUpdateByIdQueryHandler;
        private readonly UpdateProductCommandHandler _updateProductCommandHandler;

        public DefaultController(GetProductQueryHandler getProductQueryHandler)
        {
            _getProductQueryHandler = getProductQueryHandler;
        }

        public DefaultController(GetProductByIDQueryHandler getProductByIDQueryHandler)
        {
            _getProductByIDQueryHandler = getProductByIDQueryHandler;
        }

        public DefaultController(RemoveProductCommandHandler removeProductCommandHandler)
        {
            _removeProductCommandHandler = removeProductCommandHandler;
        }

        public DefaultController(GetProductUpdateByIdQueryHandler getProductUpdateByIdQueryHandler)
        {
            _getProductUpdateByIdQueryHandler = getProductUpdateByIdQueryHandler;
        }

        public DefaultController(UpdateProductCommandHandler updateProductCommandHandler)
        {
            _updateProductCommandHandler = updateProductCommandHandler;
        }

        public IActionResult Index()
        {
            var values = _getProductQueryHandler.Handle();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddProduct()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddProduct(CreateProductCommand command)
        {
            _createProductCommandHandler.Handle(command);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult GetProduct(int id)
        {
            var values = _getProductByIDQueryHandler.Handle(new GetProductByIDQuery(id));
            return View(values);
        }

        public IActionResult DeleteProduct(int id)
        {
            _removeProductCommandHandler.Handle(new RemoveProductCommand(id));
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateProduct(int id)
        {
            var values = _getProductUpdateByIdQueryHandler.Handle(new GetProductUpdateByIdQuery(id));
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateProduct(UpdateProductCommand command)
        {
            _updateProductCommandHandler.Handle(command);
            return RedirectToAction("Index");
        }
    }
}
 