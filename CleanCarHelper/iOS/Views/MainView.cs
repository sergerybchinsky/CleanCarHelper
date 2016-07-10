using System;
using UIKit;
using Foundation;
using MvvmCross.iOS.Views;

namespace CleanCarHelper.iOS
{

	[Register("MainView")]
	public class MainView : MvxViewController
	{

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			this.View.BackgroundColor = UIColor.Blue;
		}
	}
}

