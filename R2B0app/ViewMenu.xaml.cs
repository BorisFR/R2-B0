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

			var tapStop = new TapGestureRecognizer ();
			tapStop.Tapped += (s, e) => {
				Global.ForBinding.IsStop = true;
				Communication.SendCommand (R2Command.AudioStop);
			};
			btStop.GestureRecognizers.Add (tapStop);

			var tapPause = new TapGestureRecognizer ();
			tapPause.Tapped += (s, e) => {
				if (Global.IsStop) return;
				if (Global.IsPlaying) {
					Global.ForBinding.IsPlaying = false;
				} else {
					Global.ForBinding.IsPlaying = true;
				}
			};
			btPause.GestureRecognizers.Add (tapPause);

			var tapMute = new TapGestureRecognizer ();
			tapMute.Tapped += (s, e) => {
				if (Global.ForBinding.UnMute)
					Global.ForBinding.UnMute = false;
				else
					Global.ForBinding.UnMute = true;
			};
			btMute.GestureRecognizers.Add (tapMute);

			var tapVolumeDown = new TapGestureRecognizer ();
			tapVolumeDown.Tapped += (s, e) => {
				Global.ForBinding.Volume = Global.ForBinding.Volume - 1;
			};
			btVolumeDown.GestureRecognizers.Add (tapVolumeDown);

			var tapVolumeUp = new TapGestureRecognizer ();
			tapVolumeUp.Tapped += (s, e) => {
				Global.ForBinding.Volume = Global.ForBinding.Volume + 1;
			};
			btVolumeUp.GestureRecognizers.Add (tapVolumeUp);

		}

		void ButtonClicked (object sender, EventArgs e)
		{
			Button button = sender as Button;
			TestObj param = (TestObj)button.CommandParameter;
			Global.MainPage.ShowPage (param);
		}

		void BtStopClicked (object sender, System.EventArgs e)
		{
			Communication.SendCommand (R2Command.AudioStop);
		}

	}
}