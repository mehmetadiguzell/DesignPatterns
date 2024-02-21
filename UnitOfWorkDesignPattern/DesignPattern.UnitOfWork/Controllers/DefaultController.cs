using DesignPattern.BusinessLayer.Abstract;
using DesignPattern.EntityLayer.Concrete;
using DesignPattern.UnitOfWork.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DesignPattern.UnitOfWork.Controllers
{
    public class DefaultController : Controller
    {
        private readonly ICustomerService _customerService;

        public DefaultController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(CustomerViewModel viewModel)
        {

            var value1 = _customerService.TGetById(viewModel.SenderID);
            var value2 = _customerService.TGetById(viewModel.ReceiverID);

            value1.CustomerBalance-= viewModel.Amount;
            value1.CustomerBalance+= viewModel.Amount;

            List<Customer> c = new()
            {
                value1,value2
            };
            _customerService.tMultiUpdate(c);
            return View();
        }
    }
}
