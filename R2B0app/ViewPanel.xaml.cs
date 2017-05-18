using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace R2B0app
{
	public partial class ViewPanel : ContentView
	{
		public ViewPanel ()
		{
			InitializeComponent ();
			theList.ItemsSource = Global.R2panels;
		}

		void ButtonClicked (object sender, EventArgs e)
		{
			Button button = sender as Button;
			AudioObj param = (AudioObj)button.CommandParameter;
			Communication.SendCommand (param.Command, param.IdAudio);
		}

	}
}