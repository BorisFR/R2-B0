using Xamarin.Forms;

namespace R2B0app
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent ();
			Global.Init ();
			MainPage = new R2B0appPage ();
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
