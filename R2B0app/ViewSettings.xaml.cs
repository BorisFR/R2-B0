using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace R2B0app
{
	public partial class ViewSettings : ContentView
	{
		public ViewSettings ()
		{
			InitializeComponent ();

			btStopAudio.Clicked += (sender, e) => {
				Communication.SendCommand (R2Command.AudioStop);
			};
		}
	}
}