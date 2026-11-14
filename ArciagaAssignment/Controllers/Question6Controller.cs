using ArciagaAssignment.Models;
using Microsoft.AspNetCore.Mvc;

namespace ArciagaAssignment.Controllers
{
    public class Question6Controller : Controller
    {
        public ActionResult Index()
        {
            var model = new Question6ViewModel();
            return View(model);
        }
    }
}
