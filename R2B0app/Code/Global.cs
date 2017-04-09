using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace R2B0app
{
	public static class Global
	{

		public static int sendingCommand = 0;
		public static int sendCommand = 0;
		public static int sendCommandOk = 0;
		public static string lastErrorMessage = string.Empty;
		public static ForBinding ForBinding = new ForBinding ();

		public static int Volume = 50;
		public static bool Mute = false;
		public static int FrequenceBruitage = 10;
		public static bool RandomBruitage = true;

		public static string IpAddress = "192.168.4.1";

		public static R2B0appPage MainPage;

		public static ObservableCollection<TestObj> AllMenu = new ObservableCollection<TestObj> ();
		public static ObservableCollection<AudioObj> R2sounds = new ObservableCollection<AudioObj> ();
		public static ObservableCollection<AudioObj> StarWarsSounds = new ObservableCollection<AudioObj> ();
		public static ObservableCollection<AudioObj> SeriesSounds = new ObservableCollection<AudioObj> ();
		public static ObservableCollection<AudioObj> MusiqueSounds = new ObservableCollection<AudioObj> ();

		public static void Init ()
		{
			AllMenu.Add (new TestObj ("Settings", FAIcon.Cogs, Screen.Settings));
			AllMenu.Add (new TestObj ("R2 sound", FAIcon.Bullhorn, Screen.R2Sound));
			AllMenu.Add (new TestObj ("Série TV", FAIcon.Film, Screen.SeriesTV));
			AllMenu.Add (new TestObj ("Star Wars", FAIcon.Rebel, Screen.StarWars));
			AllMenu.Add (new TestObj ("Musique", FAIcon.Music, Screen.Musique));

			R2sounds.Add (new AudioObj ("Alarm (11)", 0));
			R2sounds.Add (new AudioObj ("Hum (25)", 1));
			R2sounds.Add (new AudioObj ("Misc (36)", 2));
			R2sounds.Add (new AudioObj ("Ooh (7)", 3));
			R2sounds.Add (new AudioObj ("Proc (15)", 4));
			R2sounds.Add (new AudioObj ("Razz (23)", 5));
			R2sounds.Add (new AudioObj ("Scream (4)", 6));
			R2sounds.Add (new AudioObj ("Sentence (10)", 7));
			R2sounds.Add (new AudioObj ("Whistle (25)", 8));
			R2sounds.Add (new AudioObj ("Wolf", 100));
			R2sounds.Add (new AudioObj ("Wowie", 150));
			R2sounds.Add (new AudioObj ("Annoyed", 20));
			R2sounds.Add (new AudioObj ("Chortie", 30));
			R2sounds.Add (new AudioObj ("DoDoo", 40));
			R2sounds.Add (new AudioObj ("Failure", 50));
			R2sounds.Add (new AudioObj ("Groan", 60));
			R2sounds.Add (new AudioObj ("Motivator", 140));
			R2sounds.Add (new AudioObj ("Overhere", 160));
			R2sounds.Add (new AudioObj ("Patrol", 170));
			R2sounds.Add (new AudioObj ("Question", 200));
			R2sounds.Add (new AudioObj ("Shortcut", 70));
			R2sounds.Add (new AudioObj ("Start", 180));

			StarWarsSounds.Add (new AudioObj ("Marche", FAIcon.Empire, 71));
			StarWarsSounds.Add (new AudioObj ("Cantina", FAIcon.Rebel, 72));
			StarWarsSounds.Add (new AudioObj ("Leia", FAIcon.Rebel, 73));

			SeriesSounds.Add (new AudioObj ("Invaders", FAIcon.Music, 72));

			MusiqueSounds.Add (new AudioObj ("Boris", FAIcon.Music, 74));
		}

	}
}