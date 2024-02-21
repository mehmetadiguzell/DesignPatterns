using Microsoft.AspNetCore.Mvc;
using TemplateDesignPattern.TemplatePattern;

namespace TemplateDesignPattern.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult BasicPlanIndex()
        {
            NetflixPlans netflixPlans=new BasicPlan();
            ViewBag.v1 = netflixPlans.PlanType("Temel Plan");
            ViewBag.v2 = netflixPlans.CountPerson(1);
            ViewBag.v3 = netflixPlans.Price(65.99);
            ViewBag.v4 = netflixPlans.Content("Flim-Dizi");
            ViewBag.v5 = netflixPlans.Resolution("480px");
            return View();
        }

        public IActionResult StandardPlanIndex()
        {
            NetflixPlans netflixPlans = new StandardPlan();
            ViewBag.v1 = netflixPlans.PlanType("Standard Plan");
            ViewBag.v2 = netflixPlans.CountPerson(2);
            ViewBag.v3 = netflixPlans.Price(85);
            ViewBag.v4 = netflixPlans.Content("Flim-Dizi-Animasyon");
            ViewBag.v5 = netflixPlans.Resolution("720px");
            return View();
        }

        public IActionResult UltraPlanIndex()
        {
            NetflixPlans netflixPlans = new UltraPlan();
            ViewBag.v1 = netflixPlans.PlanType("Ultra Plan");
            ViewBag.v2 = netflixPlans.CountPerson(4);
            ViewBag.v3 = netflixPlans.Price(140);
            ViewBag.v4 = netflixPlans.Content("Flim-Dizi-Animasyon-Aksiyon");
            ViewBag.v5 = netflixPlans.Resolution("1080px");
            return View();
        }
    }
}
