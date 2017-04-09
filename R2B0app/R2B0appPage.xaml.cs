using Xamarin.Forms;

namespace R2B0app
{
	public partial class R2B0appPage : ContentPage
	{
		public R2B0appPage ()
		{
			InitializeComponent ();

			Global.MainPage = this;

			viewLeft.Content = new ViewMenu ();
			viewRight.Content = new ViewSettings ();
		}

		public void ShowPage (TestObj obj)
		{
			switch (obj.Display) {
			case Screen.Settings:
				viewRight.Content = new ViewSettings ();
				break;
			case Screen.R2Sound:
				viewRight.Content = new ViewAudio (obj.Display);
				break;
			case Screen.StarWars:
				viewRight.Content = new ViewAudioIcon (obj.Display);
				break;
			case Screen.SeriesTV:
				viewRight.Content = new ViewAudioIcon (obj.Display);
				break;
			case Screen.Musique:
				viewRight.Content = new ViewAudioIcon (obj.Display);
				break;
			}
		}

	}
}