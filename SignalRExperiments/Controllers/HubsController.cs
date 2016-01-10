using System.Threading.Tasks;
using System.Web.Mvc;

namespace SignalRExperiments.Controllers
{
    public class HubsController : Controller
    {
        // GET: Hubs
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ShowJobPercentageCompleted()
        {
            return View();
        }

        [HttpPost]
        public async Task<JsonResult> ShowJobPercentageCompleted(string jobStart)
        {
            var jobService = new Services.JobService();
            await jobService.doJob();
            var json = Json(new { done = true },
                        JsonRequestBehavior.AllowGet);
            return json;
        }
    }
}