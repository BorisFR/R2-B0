using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace R2B0app
{
	public partial class ViewAudioFilm : ContentView
	{
		private Screen display;

		public ViewAudioFilm ()
		{
			InitializeComponent ();
			theList.ItemsSource = Global.SeriesSounds;
		}

		public ViewAudioFilm (Screen display)
		{
			InitializeComponent ();
			this.display = display;
			switch (display) {
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
			switch (display) {
			case Screen.SeriesTV:
				Communication.SendCommand (R2Command.PlaySerieSound, param.IdAudio, param.IdBank);
				break;
			default:
				Communication.SendCommand (R2Command.PlayR2Sound, param.IdAudio);
				break;

			}
		}

	}
}