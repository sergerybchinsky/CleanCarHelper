using System;
using MvvmCross.Core.ViewModels;

namespace CleanCarHelper.Core
{
	public class MainViewModel : MvxViewModel
	{
		private string _date = "Date";
		public string Date
		{
			get { return _date; }
			set { _date = value; RaisePropertyChanged(() => Date); }
		}
	}
}

