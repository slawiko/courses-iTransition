using System;
using System.Collections.Generic;
using UIKit;
using System.Drawing;

namespace HappyParty
{
	public partial class ViewController : UIViewController
	{
		ImageScrollView imageScrollView;
		UIImageView imageView;

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
			imageScrollView = new ImageScrollView(View);
			imageScrollView.AddImages (this.LoadImages());

			imageView = new UIImageView{
				Frame = new CoreGraphics.CGRect(View.Bounds.Top, View.Bounds.Top, View.Bounds.Width, View.Bounds.Height - imageScrollView.Height),
				BackgroundColor = new UIColor(0, 255, 0, 0)
			};

			View.BackgroundColor = UIColor.FromPatternImage (UIImage.FromBundle ("Images/background2.jpg"));

			View.AddSubview (imageView);
		}

		private List<UIImage> LoadImages()
		{
			List<UIImage> images = new List<UIImage> ();
			images.Add(UIImage.FromBundle("Images/beer.png"));
			return images;
		}
	}
}

