using System.Web.Mvc;
using WebServer.ModelBuilders;

namespace WebServer.Controllers
{
    public class FilesController : Controller
    {
        // GET: Files
        public ActionResult Index()
        {
            var viewModel = new FilesModelBuilder().GetAllFiles();
            return View(viewModel);
        }

        public ActionResult Delete(int fileId)
        {
            new FilesModelBuilder().Delete(fileId);
            return RedirectToAction("Index");
        }
    }
}