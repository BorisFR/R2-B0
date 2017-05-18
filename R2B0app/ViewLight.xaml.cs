using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace R2B0app
{
	public partial class ViewLight : ContentView
	{
		public ViewLight ()
		{
			InitializeComponent ();
			theListLights.ItemsSource = Global.R2lights;
		}


		void ButtonClicked (object sender, EventArgs e)
		{
			Button button = sender as Button;
			AudioObj param = (AudioObj)button.CommandParameter;
			Communication.SendCommand (param.Command, param.IdAudio);
		}

	}
}