using ArciagaAssignment.Models;
using Microsoft.AspNetCore.Mvc;

namespace ArciagaAssignment.Controllers
{
    public class Question2Controller : Controller
    {
        public ActionResult Index()
        {
            var model = new Question2ViewModel();
            return View(model);
        }
    }
}
