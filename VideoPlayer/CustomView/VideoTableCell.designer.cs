﻿// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace VideoPlayer.CustomView
{
    [Register ("VideoTableCell")]
    partial class VideoTableCell
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView Thumbnails { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (Thumbnails != null) {
                Thumbnails.Dispose ();
                Thumbnails = null;
            }
        }
    }
}