using DesignPattern.ChainOfResponsibilty.ChainOfResponsibility;
using DesignPattern.ChainOfResponsibilty.DAL;
using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.ChainOfResponsibilty.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(CustomerProcessViewModel model)
        {
            Employee treasurer = new Treasurer();
            Employee managerAssistant = new ManagerAsistant();
            Employee manager = new Manager();
            Employee areaDirector = new AreaDirector();

            treasurer.SetNextAprover(managerAssistant);
            managerAssistant.SetNextAprover(manager);
            manager.SetNextAprover(areaDirector);

            treasurer.ProcessRequest(model);
            return View();
        }
    }
}
