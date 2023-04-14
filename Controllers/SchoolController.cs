using Microsoft.AspNetCore.Mvc;
using web_api_v1.Models;

namespace web_api_v1.Controllers;

public class SchoolController : Controller
{
    public IActionResult Index()
    {
        var school = new School();
        school.Fundacion=2000;
        school.EscuelaId = Guid.NewGuid().ToString();
        school.Nombre="YNV";
        return View(school);
    }
}
