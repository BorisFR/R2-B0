using System;
using System.ComponentModel;

namespace R2B0app
{
	public class TestObj : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;

		private string title;
		public string Title { get { return title; } set { if (title == value) return; title = value; OnPropertyChanged ("Title"); } }

		private string icon;
		public string Icon { get { return icon; } set { if (icon == value) return; icon = value; OnPropertyChanged ("Icon"); } }

		private Screen display;
		public Screen Display { get { return display; } set { if (display == value) return; display = value; OnPropertyChanged ("Display"); } }

		public TestObj () { }
		public TestObj (string title, string icon) { Title = title; Icon = icon; }
		public TestObj (string title, string icon, Screen display) { Title = title; Icon = icon; Display = display; }

		protected virtual void OnPropertyChanged (string propertyName)
		{
			if (PropertyChanged != null) {
				PropertyChanged (this,
					new PropertyChangedEventArgs (propertyName));

			}
		}
	}
}