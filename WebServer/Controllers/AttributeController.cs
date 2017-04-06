using System.Web.Mvc;

namespace WebServer.Controllers
{
    public class AttributeController : Controller
    {

        [HttpDelete]
        public ActionResult Add(int userId)
        {
            return View();
        }
    }
}