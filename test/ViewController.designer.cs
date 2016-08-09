// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace test
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btn_easy { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnHard { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnMedium { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (btn_easy != null) {
                btn_easy.Dispose ();
                btn_easy = null;
            }

            if (btnHard != null) {
                btnHard.Dispose ();
                btnHard = null;
            }

            if (btnMedium != null) {
                btnMedium.Dispose ();
                btnMedium = null;
            }
        }
    }
}