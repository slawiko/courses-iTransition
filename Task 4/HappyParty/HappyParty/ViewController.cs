using System;
using System.Collections.Generic;
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

			this.InitialViewCreation ();
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
		}

		private void InitialViewCreation() 
		{
			ImageScrollView imageScrollView = new ImageScrollView(View);

			UIImageView imageView = new UIImageView{
				Frame = new CoreGraphics.CGRect(View.Bounds.Top, View.Bounds.Top, View.Bounds.Width, View.Bounds.Height - imageScrollView.Height),
				BackgroundColor = new UIColor(0, 255, 0, 1)
			};

			View.AddSubview (imageView);
		}
	}
}

