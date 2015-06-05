using System.Web.Helpers;
using System.Web.Mvc;
using WebGridImplementacao.Models;

namespace WebGridImplementacao.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult List()
        {
            var model = Pessoa.GetPessoas();
            return View(model);
        }

        public ActionResult Chart()
        {
            var model = Pessoa.GetPessoas();
            return View(model);
        }

        public ActionResult GetGraficoController()
        {
            var myChart = new Chart(width: 600, height: 400)
            .AddTitle("Campeonato Paulista - 2012")
           .AddSeries(
               name: "CampeonatoPaulista",
               chartType: "Pie",
               legend: "Campeonato Paulista",
               xValue: new[] { "São Paulo", "Corinthians", "Palmeiras", "Santos", "Mogi Mirim" },
               yValues: new[] { "34", "34", "32", "30", "30" })
           .Write();

            return null;
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}