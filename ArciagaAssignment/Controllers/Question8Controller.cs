using ArciagaAssignment.Models;
using Microsoft.AspNetCore.Mvc;

namespace ArciagaAssignment.Controllers
{
    public class Question8Controller : Controller
    {
        public ActionResult Index()
        {
            var model = new Question8ViewModel();
            return View(model);
        }
    }
}
