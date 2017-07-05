using System;

using UIKit;

namespace test.iOS
{
    public partial class ViewController : UIViewController
    {
        

        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Perform any additional setup after loading the view, typically from a nib.
            Button.AccessibilityIdentifier = "myButton";
            Button.TouchUpInside += delegate
            {
                if (amounttextfield.Text.Length < 1)
                {
                    return;
                }
                else {
                    var result = Convert.ToDouble(amounttextfield.Text) * 0.69;
                    resultlabel.Text = "$ "+ amounttextfield.Text + " in us dollars is equal to " + result.ToString() + "British pounds" ;
                }
            };
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.		
        }
    }
}
