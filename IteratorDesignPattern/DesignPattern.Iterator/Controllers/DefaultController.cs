using DesignPattern.Iterator.IteratorPattern;
using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.Iterator.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            VisitRouteMover visitRouteMover = new VisitRouteMover();
            List<string> routes = new List<string>();
            visitRouteMover.AddVisitRoute(new VisitRoute { 
                CountryName = "Almanya", 
                CityName = "Almanya", 
                VisitPlaceName = "Berlin Kapısı" }
            );
            visitRouteMover.AddVisitRoute(new VisitRoute
            {
                CountryName = "Fransa",
                CityName = "Paris",
                VisitPlaceName = "Eyfel Kulesi"
            });
            visitRouteMover.AddVisitRoute(new VisitRoute
            {
                CountryName = "Fransa",
                CityName = "Paris",
                VisitPlaceName = "Eyfel Kulesi"
            });
            visitRouteMover.AddVisitRoute(new VisitRoute
            {
                CountryName = "Fransa",
                CityName = "Paris",
                VisitPlaceName = "Eyfel Kulesi"
            });
            visitRouteMover.AddVisitRoute(new VisitRoute
            {
                CountryName = "Fransa",
                CityName = "Paris",
                VisitPlaceName = "Eyfel Kulesi"
            });
            var iterator = visitRouteMover.CreateIterator();
            while (iterator.NextLocation())
            {
                routes.Add(iterator.CurrentItem.CountryName + " " + iterator.CurrentItem.CityName + " " + iterator.CurrentItem.VisitPlaceName);
            }
            ViewBag.v = routes;
            return View();
        }
    }
}
