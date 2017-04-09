using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace R2B0app
{
	public partial class ViewAudioIcon : ContentView
	{
		public ViewAudioIcon ()
		{
			InitializeComponent ();
			theList.ItemsSource = Global.StarWarsSounds;
		}

		public ViewAudioIcon (Screen display)
		{
			InitializeComponent ();
			switch (display) {
			case Screen.StarWars:
				theList.ItemsSource = Global.StarWarsSounds;
				break;
			case Screen.SeriesTV:
				theList.ItemsSource = Global.SeriesSounds;
				break;
			case Screen.Musique:
				theList.ItemsSource = Global.MusiqueSounds;
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