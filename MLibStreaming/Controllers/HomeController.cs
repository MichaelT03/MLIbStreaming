using Microsoft.AspNetCore.Mvc;
using MLibStreaming.Models;
using System.Diagnostics;

namespace MLibStreaming.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}