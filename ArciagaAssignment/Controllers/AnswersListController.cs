using ArciagaAssignment.Models;
using Microsoft.AspNetCore.Mvc;

namespace ArciagaAssignment.Controllers
{
    public class AnswersListController : Controller
    {
        public IActionResult Index()
        {
            var model = new AnswersListViewModel();
            return View(model);
        }
    }
}
