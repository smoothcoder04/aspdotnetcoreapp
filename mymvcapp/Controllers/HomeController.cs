using Microsoft.AspNetCore.Mvc;

namespace mymvcapp.Controllers
{
    public class HomeController : Controller
    {
        public string index()
        {
            return "Hello WORLD!";
        }
    }
}
