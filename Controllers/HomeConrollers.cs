using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace razor_fun.Controllers
{
    public class HomeController : Controller
{
    [HttpGet("")]
    public ViewResult Index()
    {
        return View("Index");
    }
}
}