using System;
using System.Collections.Generic;
using UIKit;

namespace HappyParty
{
	public class ImageScrollView
	{
		public nfloat Height;
		public nfloat Width;
		private UIScrollView scrollView;
		public CoreGraphics.CGSize ImageSize;

		public ImageScrollView (UIView View)
		{
			this.Height = 100.0f;
			this.Width = View.Bounds.Width;
			this.scrollView = new UIScrollView {
				Frame = new CoreGraphics.CGRect (View.Bounds.Top, View.Bounds.Bottom - this.Height, View.Bounds.Width, this.Height),
				BackgroundColor = new UIColor(0, 0, 255, 0)
			};
			this.ImageSize = new CoreGraphics.CGSize(100.0f, 100.0f);

			this.Blur (View);
			View.AddSubview (this.scrollView);
		}

		public ImageScrollView (UIView View, bool isBlur)
		{
			this.Height = 100.0f;
			this.Width = View.Bounds.Width;
			this.scrollView = new UIScrollView {
				Frame = new CoreGraphics.CGRect (View.Bounds.Top, View.Bounds.Bottom - this.Height, View.Bounds.Width, this.Height),
				BackgroundColor = new UIColor(0, 0, 255, 0)
			};
			this.ImageSize = new CoreGraphics.CGSize(100.0f, 100.0f);

			if (isBlur)
				this.Blur (View);

			View.AddSubview (this.scrollView);
		}

		public ImageScrollView (UIView View, nfloat Height, nfloat Width, UIColor BackgroundColor, CoreGraphics.CGSize imageSize)
		{
			this.Height = Height;
			this.Width = Width;
			this.scrollView = new UIScrollView {
				Frame = new CoreGraphics.CGRect (View.Bounds.Top, View.Bounds.Bottom - this.Height, View.Bounds.Width, this.Height),
				BackgroundColor = BackgroundColor
			};
			this.ImageSize = imageSize;

			View.AddSubview (this.scrollView);
		}

		public void AddImages (List<UIImage> Images)
		{
			for (int i = 0; i < Images.Count; i++)
			{
				this.scrollView.AddSubview(new UIImageView{
					Frame = new CoreGraphics.CGRect(this.ImageSize.Width * i, 0, this.ImageSize.Width, this.ImageSize.Height),
					Image = Images[i]
				});
			}
			this.scrollView.ContentSize = new CoreGraphics.CGSize (ImageSize.Width * Images.Count,
				this.Height);
		}

		private void Blur(UIView View)
		{
			UIVisualEffectView blurView = new UIVisualEffectView (UIBlurEffect.FromStyle (UIBlurEffectStyle.Light)) {
				Frame = new CoreGraphics.CGRect (View.Bounds.Top, View.Bounds.Bottom - this.Height, View.Bounds.Width, this.Height)
			};

			View.Add (blurView);
		}
	}
}
