using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace YouTunes.Models
{
    public class VideoModel
    {
        [Display(Name = "Video Title")]
        public string VideoTitle { get; set; }

        public string VideoId { get; set; }
    }
}