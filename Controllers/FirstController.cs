using Microsoft.AspNetCore.Mvc;
using System;

namespace Portfolio_II.Controllers
{
    public class FirstController : Controller
    {
        [HttpGet]
        [Route("")]
        public ViewResult Index()
        {
            return View("Index");
        }

        [HttpGet]
        [Route("projects")]
        public ViewResult Projects()
        {
            return View ("Projects");
        }

        [HttpGet]
        [Route("contacts")]
        public ViewResult Contacts()
        {
            return View ("Contacts");
        }

        [HttpPost("process")]
        public RedirectToActionResult Submit()
        {
            return RedirectToAction("Index");
        }



    }
}
