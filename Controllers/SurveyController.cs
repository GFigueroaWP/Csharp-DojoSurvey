using Microsoft.AspNetCore.Mvc;

namespace DojoSurvey.Controllers;

public class SurveyController : Controller
{
    [HttpGet]
    [Route("")]
    public ViewResult Index()
    {
        return View();
    }

    [HttpPost("survey")]
    public IActionResult Survey(string Name, string Location, string Language, string Comment)
    {
        ViewBag.Name = Name;
        ViewBag.Location = Location;
        ViewBag.Language = Language;
        ViewBag.Comment = Comment;

        return View("survey");
    }

}