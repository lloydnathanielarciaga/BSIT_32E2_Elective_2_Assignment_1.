using ArciagaAssignment.Models;
using Microsoft.AspNetCore.Mvc;

namespace ArciagaAssignment.Controllers
{
    public class Question4Controller : Controller
    {
        public ActionResult Index()
        {
            var model = new Question4ViewModel();
            return View(model);
        }
    }
}
