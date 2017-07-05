// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace test.iOS
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        UIKit.UIButton Button { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField amounttextfield { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel resultlabel { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (amounttextfield != null) {
                amounttextfield.Dispose ();
                amounttextfield = null;
            }

            if (Button != null) {
                Button.Dispose ();
                Button = null;
            }

            if (resultlabel != null) {
                resultlabel.Dispose ();
                resultlabel = null;
            }
        }
    }
}