using System;
using System.Drawing;

using CoreFoundation;
using UIKit;
using Foundation;

namespace VideoPlayer.Controllers
{
    [Register("MainController")]
    public class MainController : UITabBarController
    {
        public MainController(IntPtr p) : base(p)
        {
            // home
            ViewControllers[0].TabBarItem.Title = "ホーム";
            //ViewControllers[0].TabBarItem.Image = 
            var homeIcon = UIImage.FromFile("Images/home");
            ViewControllers[0].TabBarItem.Image = homeIcon;

            // profile
            ViewControllers[1].TabBarItem.Title = "プロファイル";
            ViewControllers[1].TabBarItem.Image = UIImage.FromFile("Images/customer");
        }

        public override void DidReceiveMemoryWarning()
        {
            // Releases the view if it doesn't have a superview.
            base.DidReceiveMemoryWarning();

            // Release any cached data, images, etc that aren't in use.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
        }
    }
}