using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace YouTunes.Controllers
{
    public class BaseController : Controller
    {
        [HttpGet]
        public ActionResult SearchYoutube(string videoId)
        {
            return RedirectToAction("Results", "Search", new { videoId = videoId });
        }
    }
}
