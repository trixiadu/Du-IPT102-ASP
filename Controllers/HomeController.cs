using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        var studentInfoArray = new[]
        {
            new StudentInfoModel { Name = "Trixia Du", StudentId = "21-1482", StudentAge = "20" },
            new StudentInfoModel { Name = "Marlita Du", StudentId = "21-1477", StudentAge = "41" },
            new StudentInfoModel { Name = "Roberto Sison", StudentId = "21-1422", StudentAge = "44" }
        };

        return View(studentInfoArray);
    }
}
