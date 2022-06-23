using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;

namespace web.Controllers
{
    public class BoxController : Controller
    {
        private readonly ILogger<BoxController> _logger;

        public BoxController(ILogger<BoxController> logger)
        {
            _logger = logger;
        }

        public IActionResult Init()
        {
            return View("box");
        }

        [HttpPost]
        public IActionResult Login()
        {
            return View("box");
        }
    }
}
