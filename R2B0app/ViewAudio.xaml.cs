using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace R2B0app
{
	public partial class ViewAudio : ContentView
	{
		public ViewAudio ()
		{
			InitializeComponent ();
			theList.ItemsSource = Global.R2sounds;
		}

		public ViewAudio (Screen display)
		{
			InitializeComponent ();
			switch (display) {
			case Screen.R2Sound:
				theList.ItemsSource = Global.R2sounds;
				break;
			}
		}

		void ButtonClicked (object sender, EventArgs e)
		{
			Button button = sender as Button;
			AudioObj param = (AudioObj)button.CommandParameter;
			Communication.SendCommand (R2Command.PlayR2Sound, param.IdAudio);
		}

	}
}