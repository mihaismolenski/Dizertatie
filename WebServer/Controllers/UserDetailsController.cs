using System;
using System.Web.Mvc;
using WebServer.ModelBuilders;
using WebServer.ViewModels;

namespace WebServer.Controllers
{
    public class UserDetailsController : Controller
    {
        private readonly UserDetailsModelBuilder _userDetailsModelBuilder;

        public UserDetailsController()
        {
            _userDetailsModelBuilder = new UserDetailsModelBuilder();
        }

        // GET: UserDetails
        public ActionResult Index(int userId)
        {
            var model = _userDetailsModelBuilder.GetModel(userId);
            return View(model);
        }

        [HttpGet]
        public ActionResult DeleteAttribute(int userId, int attributeId)
        {
            _userDetailsModelBuilder.DeleteUserAttribute(userId, attributeId);
            return RedirectToAction("Index", new {userId});
        }

        public ActionResult AddUserAttribute(UserViewModel model)
        {
            _userDetailsModelBuilder.AddUserAttribute(model.UserId, Convert.ToInt32(model.NewAttributeType), model.NewAttributeValue);
            return RedirectToAction("Index", new { userId = model.UserId });
        }
    }
}