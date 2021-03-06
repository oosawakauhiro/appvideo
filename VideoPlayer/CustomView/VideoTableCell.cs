﻿using System;
using System.Threading.Tasks;
using Foundation;
using UIKit;
using VideoPlayer.Service.Models;

namespace VideoPlayer.CustomView
{
    public partial class VideoTableCell : UITableViewCell
    {
        public static readonly NSString Key = new NSString("VideoTableCell");
        public static readonly UINib Nib;

        static VideoTableCell()
        {
            Nib = UINib.FromName("VideoTableCell", NSBundle.MainBundle);
        }

        protected VideoTableCell(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public async Task Update(Video video)
        {
            //    LblTitle.Text = video.Name;
            //    LblTitle.Lines = 0;
            //    LblTitle.SizeToFit();
            //    LblTitle.BackgroundColor = UIColor.FromRGBA(0, 0, 0, 0.6f);
            await Thumbnails.LoadImageFromUriAsync(video.Img);
            var imgSize = Thumbnails.Image.Size;
            var frame = Thumbnails.Frame;
            var height = imgSize.Height / imgSize.Width * frame.Width;
            frame.Height = height;
            Thumbnails.Frame = frame;
            Thumbnails.ContentMode = UIViewContentMode.ScaleAspectFit;
        }

        public override void PrepareForReuse()
        {
            base.PrepareForReuse();
        }
    }
}
