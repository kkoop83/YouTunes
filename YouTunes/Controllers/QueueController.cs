using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YouTunes.Models;

namespace YouTunes.Controllers
{
    public class QueueController : Controller
    {
        //
        // GET: /Playlist/

        public ActionResult QueueSong()
        {
            var modelList = new List<VideoModel>();

            return PartialView("_Queue", modelList);
        }

        [HttpPost]
        public ActionResult QueueSong(string videoId, string videoTitle)
        {
            var modelList = GetQueue() ?? new List<VideoModel>();

            var videoAlreadyQueued = false;

            foreach (var video in modelList)
            {
                if (video.VideoId == videoId)
                    videoAlreadyQueued = true;                
            }

            if (videoAlreadyQueued)
                videoAlreadyQueued = true; //TODO: Video already queued error
            else
                modelList.Add(new VideoModel() { VideoId = videoId, VideoTitle = videoTitle });

            SetQueue(modelList);
            return PartialView("_Queue",modelList);
        }



        private void SetQueue(List<VideoModel> modelList) { TempData["Queue"] = modelList; }
        private List<VideoModel> GetQueue() { return (List<VideoModel>)TempData["Queue"]; } 
    }
}
