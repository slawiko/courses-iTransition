using System;

using UIKit;

namespace HappyParty
{
	public partial class ViewController : UIViewController
	{
		public ViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			// Perform any additional setup after loading the view, typically from a nib.

			nfloat scrollViewHeight = 100;

			UIImageView imageView = new UIImageView{
				Frame = new CoreGraphics.CGRect(View.Bounds.Top, View.Bounds.Top, View.Bounds.Width, View.Bounds.Height - scrollViewHeight)
			};

			UIScrollView scrollView = new UIScrollView {
				Frame = new CoreGraphics.CGRect (View.Bounds.Top, View.Bounds.Bottom - scrollViewHeight, View.Bounds.Width, scrollViewHeight)
			};

			View.AddSubview (scrollView);
			View.AddSubview (imageView);
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}

