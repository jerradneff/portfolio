using Microsoft.AspNetCore.Mvc;
using portfolio.Data;
namespace portfolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISkillsRepo _skillsRepo;
        public HomeController(ISkillsRepo skillsRepo)
        {
            _skillsRepo = skillsRepo;
        }

        public IActionResult Index()
        {
            return View(_skillsRepo.GetSkills());
        }
    }
}
