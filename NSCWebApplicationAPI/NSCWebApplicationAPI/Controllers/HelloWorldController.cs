using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace NSCWebApplicationAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HelloWorldController : Controller
    {
        // GET: HomeController
        //[HttpGet(Name = "GetHelloWorld")]
        public string Index()
        {
            return "HelloWorld!";
        }
    }
}
