using System;
using System.Web.Mvc;
using WebServer.ModelBuilders;
using WebServer.ViewModels;

namespace WebServer.Controllers
{
    public class FileDetailsController : Controller
    {
        // GET: FileDetails
        public ActionResult Index(int fileId)
        {
            var viewModel = new FileDetailsModelBuilder().GetFile(fileId);
            return View(viewModel);
        }

        public ActionResult Add()
        {
            var viewModel = new FileViewModel
            {
                CreatedDate = DateTime.Now
            };
            return View("Index", viewModel);
        }

        public ActionResult Save(FileViewModel model)
        {
            var result = new FileDetailsModelBuilder().SaveFile(model);
            return View("Index", result);
        }

        [HttpGet]
        public JsonResult GetAccessTree(int fileId)
        {
            var accessTree = new FileDetailsModelBuilder().GetAccessTree(fileId);
            return Json(accessTree, JsonRequestBehavior.AllowGet);
        }
    }
}