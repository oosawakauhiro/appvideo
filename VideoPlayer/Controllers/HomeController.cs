using Foundation;
using System;

using UIKit;
using VideoPlayer.CustomView;
using VideoPlayer.Service;

namespace VideoPlayer
{
    [Register("HomeController")]
    public partial class HomeController : UIViewController
    {
        [Outlet]
        public UILabel LblTabGame { get; set; }

        [Outlet]
        public UITableView TblVideo { get; set; }

        public HomeController(IntPtr handle) : base (handle)
        {
        }

        public override async void ViewDidLoad ()
        {
            base.ViewDidLoad ();
            View.BackgroundColor = UIColor.FromRGB(63, 63, 63);
            TblVideo.RowHeight = UITableView.AutomaticDimension;
            TblVideo.EstimatedRowHeight = 150;
            //TblVideo.RowHeight = 150;
            TblVideo.RegisterNibForCellReuse(UINib.FromName("VideoTableCell", null), "Cell");
            var data = await new VideoService().GetVideoList();
            TblVideo.Source = new VideoTableSource(data);
            TblVideo.ReloadData();
        }

        public override void DidReceiveMemoryWarning ()
        {
            base.DidReceiveMemoryWarning ();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}