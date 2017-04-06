using System.Web.Mvc;
using WebServer.ModelBuilders;

namespace WebServer.Controllers
{
    public class UsersController : Controller
    {
        private readonly UsersModelBuilder _usersModelBuilder;

        public UsersController()
        {
            _usersModelBuilder = new UsersModelBuilder();
        }

        public ActionResult Index()
        {
            var model = _usersModelBuilder.GetViewModel();
            return View(model);
        }
    }
}