using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Google.YouTube;
using Google.GData.YouTube;
using Google.GData.Client;
using YouTunes.Models;

namespace YouTunes.Services
{
    public class YoutubeService : BaseService
    {
        public IEnumerable<VideoModel> Search(string searchText)
        {
            var modelList = new List<VideoModel>();
            var settings = new YouTubeRequestSettings("YouTunes", "AIzaSyCgNs6G_0w36g6dhAxxBL4nL7wD3C6jmOw");
            var request = new YouTubeRequest(settings);
            var query = new YouTubeQuery("https://gdata.youtube.com/feeds/api/videos") { Query = searchText };

            Feed<Video> feed = null;

            try
            {
                feed = request.Get<Video>(query);

                foreach (var video in feed.Entries)
                {
                    modelList.Add(new VideoModel() { VideoTitle = video.Title, VideoId = video.VideoId });
                }
            }
            catch (GDataRequestException gdre)
            {

            }

            return modelList;
        }
    }
}