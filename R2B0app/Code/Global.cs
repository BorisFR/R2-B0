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

			StarWarsSounds.Add (new AudioObj ("Star Wars", FAIcon.Empire, 5, 50));
			StarWarsSounds.Add (new AudioObj ("Marche", FAIcon.Empire, 5, 51));
			StarWarsSounds.Add (new AudioObj ("Battle of the Heroes", FAIcon.Empire, 5, 52));
			StarWarsSounds.Add (new AudioObj ("Cantina", FAIcon.Rebel, 5, 53));
			StarWarsSounds.Add (new AudioObj ("Leia", FAIcon.Rebel, 9, 97));

			SeriesSounds.Add (new AudioObj ("Austin Powers", FAIcon.Music, 6, 0));
			SeriesSounds.Add (new AudioObj ("Back to the future", FAIcon.Music, 6, 1));
			SeriesSounds.Add (new AudioObj ("Back to the future III", FAIcon.Music, 6, 2));
			SeriesSounds.Add (new AudioObj ("Battlestar Galactica", FAIcon.Music, 6, 3));
			SeriesSounds.Add (new AudioObj ("Doctor Who", FAIcon.Music, 6, 27));
			SeriesSounds.Add (new AudioObj ("Fringe", FAIcon.Music, 6, 4));
			SeriesSounds.Add (new AudioObj ("Game of Thrones", FAIcon.Music, 6, 5));
			SeriesSounds.Add (new AudioObj ("Ghostbusters", FAIcon.Music, 6, 6));
			SeriesSounds.Add (new AudioObj ("Ghostbusters", FAIcon.Music, 6, 7));
			SeriesSounds.Add (new AudioObj ("Logan's Run", FAIcon.Music, 6, 8));
			SeriesSounds.Add (new AudioObj ("Six Million Dollar Man", FAIcon.Music, 6, 9));
			SeriesSounds.Add (new AudioObj ("Space 1999", FAIcon.Music, 6, 10));
			SeriesSounds.Add (new AudioObj ("Star Trek", FAIcon.Music, 6, 11));
			SeriesSounds.Add (new AudioObj ("Star Trek Voyager", FAIcon.Music, 6, 12));
			SeriesSounds.Add (new AudioObj ("Stargate", FAIcon.Music, 6, 24));
			SeriesSounds.Add (new AudioObj ("Stargate SG-1", FAIcon.Music, 6, 25));
			SeriesSounds.Add (new AudioObj ("Stargate Atlantis", FAIcon.Music, 6, 26));
			SeriesSounds.Add (new AudioObj ("The Invaders", FAIcon.Music, 6, 13));
			SeriesSounds.Add (new AudioObj ("The Outer Limits", FAIcon.Music, 6, 14));
			SeriesSounds.Add (new AudioObj ("The Prisoner", FAIcon.Music, 6, 15));
			SeriesSounds.Add (new AudioObj ("The Terminator", FAIcon.Music, 6, 16));
			SeriesSounds.Add (new AudioObj ("The Twilight Zone", FAIcon.Music, 6, 17));
			SeriesSounds.Add (new AudioObj ("The Walking Dead", FAIcon.Music, 6, 18));
			SeriesSounds.Add (new AudioObj ("The X-FILES", FAIcon.Music, 6, 19));
			SeriesSounds.Add (new AudioObj ("Thunderbirds", FAIcon.Music, 6, 20));
			SeriesSounds.Add (new AudioObj ("The Time Tunnel", FAIcon.Music, 6, 21));
			SeriesSounds.Add (new AudioObj ("Tron Legacy", FAIcon.Music, 6, 22));
			SeriesSounds.Add (new AudioObj ("V", FAIcon.Music, 6, 23));

			MusiqueSounds.Add (new AudioObj ("Boris", FAIcon.Music, 74));
		}

	}
}