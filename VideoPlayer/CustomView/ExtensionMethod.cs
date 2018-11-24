
using Foundation;
using System.Net.Http;
using System.Threading.Tasks;
using UIKit;
using VideoPlayer.Service;

namespace VideoPlayer.CustomView
{
    public static class ExtensionMethod
    {
        public static async Task LoadImageFromUriAsync(this UIImageView img, string uri)
        {
            img.Image = UIImage.LoadFromData(NSData.FromArray(await new VideoService().GetBytesFromUri(uri)));
        }
    }
}