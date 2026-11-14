using ArciagaAssignment.Models;
using Microsoft.AspNetCore.Mvc;

namespace ArciagaAssignment.Controllers
{
    public class Question1Controller : Controller
    {
        public ActionResult Index()
        {
            var model = new Question1ViewModel();
            return View(model);
        }
    }
}
