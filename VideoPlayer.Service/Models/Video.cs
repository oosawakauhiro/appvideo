using System;
using System.Collections.Generic;
using System.Text;

namespace VideoPlayer.Service.Models
{
    public class Video
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Img { get; set; }
        public string Like { get; set; }
        public string Dislike { get; set; }
        public string ProfileImg { get; set; }
        public string ProfileName { get; set; }
    }
}
