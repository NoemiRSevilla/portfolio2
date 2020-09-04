using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
namespace PortfolioII.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        [Route("")]
        public ViewResult Index()
        {
            return View();
        }
        [HttpGet("projects")]
        public ViewResult Projects()
        {
            return View();
        }
        [HttpGet("contact")]
        public ViewResult Contact()
        {
            return View();
        }
    }
}