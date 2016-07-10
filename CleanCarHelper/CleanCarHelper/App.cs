using System;
using MvvmCross.Platform.IoC;

namespace CleanCarHelper.Core
{
	public class App : MvvmCross.Core.ViewModels.MvxApplication
	{
		public override void Initialize()
		{
			CreatableTypes()
				.EndingWith("Service")
				.AsInterfaces()
				.RegisterAsLazySingleton();

			RegisterAppStart<MainViewModel>();
		}
	}
}

