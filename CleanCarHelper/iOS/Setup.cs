using System;
using MvvmCross.iOS.Platform;
using MvvmCross.iOS.Views.Presenters;

namespace CleanCarHelper.iOS
{
	public class Setup  : MvxIosSetup
	{
		public Setup(MvxApplicationDelegate applicationDelegate, IMvxIosViewPresenter presenter)
			: base(applicationDelegate, presenter)
		{
			
		}

		protected override MvvmCross.Core.ViewModels.IMvxApplication CreateApp()
		{
			return new CleanCarHelper.Core.App();
		}
	}
}

