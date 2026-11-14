using ArciagaAssignment.Models;
using Microsoft.AspNetCore.Mvc;

namespace ArciagaAssignment.Controllers
{
    public class Question3Controller : Controller
    {
        public ActionResult Index()
        {
            var model = new Question3ViewModel();
            return View(model);
        }
    }
}
