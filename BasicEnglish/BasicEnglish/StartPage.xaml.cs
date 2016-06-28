using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace BasicEnglish
{
	public partial class StartPage : ContentPage
	{
		public StartPage()
		{
			InitializeComponent();
		}

		void OnClick_Learn(object sender, System.EventArgs e)
		{
			Navigation.PushAsync(new LearningPage());
		}

		void OnClick_Practice(object sender, System.EventArgs e)
		{
			Navigation.PushAsync(new PracticingPage());
		}
	}
}

