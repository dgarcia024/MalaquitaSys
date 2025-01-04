using MalaquitaSystem.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace MalaquitaSystem.Web.Controllers
{
    public class TestController : Controller
    {
        // GET: TestController
        public ActionResult Index()
        {
            var data = new TestViewModel 
            {
                Name = "Anthony G Almeida",
                BithDate = new DateOnly(1993,04,24)
            };
            return View(data);
        }

    }
}
