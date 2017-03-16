using System.Web.Mvc;

namespace WebServer.Controllers
{
    public class FilesController : Controller
    {
        // GET: Files
        public ActionResult Index()
        {
            return View();
        }
    }
}