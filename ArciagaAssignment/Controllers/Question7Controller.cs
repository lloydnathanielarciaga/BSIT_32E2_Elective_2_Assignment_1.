using ArciagaAssignment.Models;
using Microsoft.AspNetCore.Mvc;

namespace ArciagaAssignment.Controllers
{
    public class Question7Controller : Controller
    {
        public ActionResult Index()
        {
            var model = new Question7ViewModel();
            return View(model);
        }
    }
}
