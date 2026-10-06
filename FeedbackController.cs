using Microsoft.AspNetCore.Mvc;
using Practical7.Models;

namespace Practical7.Controllers
{
    public class FeedbackController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View(new FeedbackViewModel());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SubmitFeedback(FeedbackViewModel model)
        {
            if (ModelState.IsValid)
            {
                TempData["SuccessMessage"] = "Thank you! Your feedback has been recorded successfully.";
                return RedirectToAction("Index");
            }

           
            return View("Index", model);
        }
    }
}
