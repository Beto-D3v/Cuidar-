using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return File("CuidarMais\\Frontend\\telalogin.html", "text/html");
    }
}