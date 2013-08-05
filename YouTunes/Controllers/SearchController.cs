using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YouTunes.Services;

namespace YouTunes.Controllers
{
    public class SearchController : BaseController
    {
       
        [HttpPost]
        public ActionResult Results(string searchText)
        {
            //TODO: Add more search options
            var youtube = new YoutubeService();
            var modelList = youtube.Search(searchText);

            return PartialView(modelList);
        }

    }
}
