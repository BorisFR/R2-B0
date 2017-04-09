using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace R2B0app
{
	public partial class ViewMenu : ContentView
	{
		public ViewMenu ()
		{
			InitializeComponent ();
			theList.ItemsSource = Global.AllMenu;
		}

		void ButtonClicked (object sender, EventArgs e)
		{
			Button button = sender as Button;
			TestObj param = (TestObj)button.CommandParameter;
			Global.MainPage.ShowPage (param);
		}

	}
}
