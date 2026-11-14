using ArciagaAssignment.Models;
using Microsoft.AspNetCore.Mvc;

namespace ArciagaAssignment.Controllers
{
    public class Question5Controller : Controller
    {
        public ActionResult Index()
        {
            var model = new Question5ViewModel();
            return View(model);
        }
    }
}
