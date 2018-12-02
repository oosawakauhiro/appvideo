using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace VideoPlayer.Service.Models
{
    public class Video
    {
        [JsonProperty("video_id")]
        public string VideoId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
        public string Img { get; set; }
        public string Like { get; set; }
        public string Dislike { get; set; }
        public string ProfileImg { get; set; }
        public string ProfileName { get; set; }
    }
}
