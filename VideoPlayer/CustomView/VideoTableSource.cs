using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Foundation;
using UIKit;
using VideoPlayer.Service.Models;

namespace VideoPlayer.CustomView
{
    public class VideoTableSource : UITableViewSource
    {
        static readonly NSString CellIdentifier = new NSString("Cell");

        List<Video> data;

        public VideoTableSource(List<Video> data)
        {
            this.data = data;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            var video = data[indexPath.Row];

            var cell = tableView.DequeueReusableCell(CellIdentifier, indexPath) as VideoTableCell;
            cell.SelectionStyle = UITableViewCellSelectionStyle.None;
            cell.PreservesSuperviewLayoutMargins = false;
            cell.SeparatorInset = UIEdgeInsets.Zero;
            cell.LayoutMargins = UIEdgeInsets.Zero;
            UpdateCell(cell, video).ContinueWith(task =>
            {

            });

            return cell;
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return data.Count;
        }

        private async Task UpdateCell(VideoTableCell cell, Video video)
        {
            await cell.Update(video);
        }
    }
}