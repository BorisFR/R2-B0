using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace R2B0app
{
	public partial class ViewAudioIcon : ContentView
	{
		private Screen display;

		public ViewAudioIcon ()
		{
			InitializeComponent ();
			theList.ItemsSource = Global.StarWarsSounds;
		}

		public ViewAudioIcon (Screen display)
		{
			InitializeComponent ();
			this.display = display;
			switch (display) {
			case Screen.StarWars:
				theList.ItemsSource = Global.StarWarsSounds;
				break;
			}
		}

		void ButtonClicked (object sender, EventArgs e)
		{
			Button button = sender as Button;
			AudioObj param = (AudioObj)button.CommandParameter;
			switch (display) {
			case Screen.StarWars:
				Global.ForBinding.IsPlaying = true;
				Communication.SendCommand (R2Command.PlayStarWarsSound, param.IdAudio, param.IdBank);
				break;
			}
		}

	}
}