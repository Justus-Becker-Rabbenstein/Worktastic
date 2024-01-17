using Microsoft.AspNetCore.Mvc;

namespace Worktastic.Controllers
{
    public class JobPostingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CreateEditJobPosting(int id) { 
            return View();
        }
    }
}
