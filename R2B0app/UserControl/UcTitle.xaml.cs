using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace R2B0app
{
	public partial class UcTitle : ContentView
	{
		public string Icon {
			get {
				return theIcon.Text;
			}
			set {
				theIcon.Text = value;
			}
		}

		public string Text {
			get {
				return theText.Text;
			}
			set {
				theText.Text = value;
			}
		}
		public UcTitle ()
		{
			InitializeComponent ();
		}

	}
}