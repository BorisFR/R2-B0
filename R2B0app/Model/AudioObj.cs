using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace R2B0app
{
	public class AudioObj : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;

		private string title;
		public string Title { get { return title; } set { if (title == value) return; title = value; OnPropertyChanged ("Title"); } }

		private string icon;
		public string Icon { get { return icon; } set { if (icon == value) return; icon = value; OnPropertyChanged ("Icon"); } }

		private int idAudio;
		public int IdAudio { get { return idAudio; } set { if (idAudio == value) return; idAudio = value; OnPropertyChanged ("IdAudio"); } }

		private int idBank;
		public int IdBank { get { return idBank; } set { if (idBank == value) return; idBank = value; OnPropertyChanged ("IdBank"); } }

		public ImageSource Picture {
			get {
				try {
					var imageSource = ImageSource.FromResource ($"R2B0app.Images.{icon}.png");
					return imageSource;
				} catch (Exception err) {
					System.Diagnostics.Debug.WriteLine ("********** ERROR: " + err.Message);
				}
				return null;

			}
		}

		public AudioObj () { }
		public AudioObj (string title, string icon) { Title = title; Icon = icon; }
		public AudioObj (string title, int idAudio) { Title = title; IdAudio = idAudio; }
		public AudioObj (string title, string icon, int idAudio) { Title = title; Icon = icon; IdAudio = idAudio; }
		public AudioObj (string title, string icon, int idAudio, int idBank) { Title = title; Icon = icon; IdAudio = idAudio; IdBank = idBank; }

		protected virtual void OnPropertyChanged (string propertyName)
		{
			if (PropertyChanged != null) {
				PropertyChanged (this,
					new PropertyChangedEventArgs (propertyName));

			}
		}
	}
}
