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
            return RedirectToAction("Index", new { fileId = result.FileId });
        }

        [HttpGet]
        public JsonResult GetAccessTree(int fileId)
        {
            var accessTree = new FileDetailsModelBuilder().GetAccessTree(fileId);
            return Json(accessTree, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult AddGate(int fileId, int parentId, int gateId)
        {
            var accessTree = new FileDetailsModelBuilder().AddGate(fileId, parentId, gateId);
            return Json(accessTree, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult AddAttribute(int fileId, int parentId, int attributeTypeId, string value)
        {
            var accessTree = new FileDetailsModelBuilder().AddAttribute(fileId, parentId, attributeTypeId, value);
            return Json(accessTree, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult AddRoot(int fileId, int gateId)
        {
            var accessTree = new FileDetailsModelBuilder().AddRoot(fileId, gateId);
            return Json(accessTree, JsonRequestBehavior.AllowGet);
        }
    }
}