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
			AllMenu.Add (new TestObj ("Movie", FAIcon.Film, Screen.SeriesTV));
			AllMenu.Add (new TestObj ("Star Wars", FAIcon.Rebel, Screen.StarWars));
			AllMenu.Add (new TestObj ("Music", FAIcon.Music, Screen.Musique));

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
			StarWarsSounds.Add (new AudioObj ("Marche Imperiale", FAIcon.Empire, 5, 51));
			StarWarsSounds.Add (new AudioObj ("Battle of the Heroes", FAIcon.Empire, 5, 52));
			StarWarsSounds.Add (new AudioObj ("Cantina", FAIcon.Rebel, 5, 53));
			StarWarsSounds.Add (new AudioObj ("Message de Leia", FAIcon.Rebel, 9, 97));

			SeriesSounds.Add (new AudioObj ("Austin Powers", "AustinPowers", 6, 0));
			SeriesSounds.Add (new AudioObj ("Back to the future", "BackToTheFuture", 6, 1));
			SeriesSounds.Add (new AudioObj ("BTTF III", "BackToTheFutureIII", 6, 2));
			SeriesSounds.Add (new AudioObj ("Battlestar Galactica", "BattlestarGalactica", 6, 3));
			SeriesSounds.Add (new AudioObj ("Doctor Who", "DoctorWho", 6, 27));
			SeriesSounds.Add (new AudioObj ("Fringe", "Fringe", 6, 4));
			SeriesSounds.Add (new AudioObj ("Game of Thrones", "GameOfThrones", 6, 5));
			SeriesSounds.Add (new AudioObj ("Ghostbusters", "Ghostbusters", 6, 6));
			SeriesSounds.Add (new AudioObj ("Ghostbusters", "GhostbustersMagic", 6, 7));
			SeriesSounds.Add (new AudioObj ("Logan's Run", "LogansRun", 6, 8));
			SeriesSounds.Add (new AudioObj ("Steve Austin", "SixMillionDollarMan", 6, 9));
			SeriesSounds.Add (new AudioObj ("Space 1999", "Space1999", 6, 10));
			SeriesSounds.Add (new AudioObj ("Stargate", "Stargate", 6, 24));
			SeriesSounds.Add (new AudioObj ("Stargate SG-1", "StargateSG1", 6, 25));
			SeriesSounds.Add (new AudioObj ("Stargate Atlantis", "StargateAtlantis", 6, 26));
			SeriesSounds.Add (new AudioObj ("Star Trek", "StarTrek", 6, 11));
			SeriesSounds.Add (new AudioObj ("Star Trek Voyager", "StarTrekVoyager", 6, 12));
			SeriesSounds.Add (new AudioObj ("The Invaders", "TheInvaders", 6, 13));
			SeriesSounds.Add (new AudioObj ("The Outer Limits", "TheOuterLimits", 6, 14));
			SeriesSounds.Add (new AudioObj ("The Prisoner", "ThePrisoner", 6, 15));
			SeriesSounds.Add (new AudioObj ("The Terminator", "TheTerminator", 6, 16));
			SeriesSounds.Add (new AudioObj ("The Time Tunnel", "TheTimeTunnel", 6, 21));
			SeriesSounds.Add (new AudioObj ("The Twilight Zone", "TheTwilightZone", 6, 17));
			SeriesSounds.Add (new AudioObj ("The Walking Dead", "TheWalkingDead", 6, 18));
			SeriesSounds.Add (new AudioObj ("The X-FILES", "TheXFiles", 6, 19));
			SeriesSounds.Add (new AudioObj ("Thunderbirds", "Thunderbirds", 6, 20));
			SeriesSounds.Add (new AudioObj ("Tron Legacy", "TronLegacy", 6, 22));
			SeriesSounds.Add (new AudioObj ("V", "V", 6, 23));

			MusiqueSounds.Add (new AudioObj ("Benny Benassi", "cd_bennybenassi", 74));
			MusiqueSounds.Add (new AudioObj ("Bomb the Bass", "cd_bombthebass", 74));
			MusiqueSounds.Add (new AudioObj ("Bonnie Tyler", "cd_bonnietyler", 74));
			MusiqueSounds.Add (new AudioObj ("Boris", "cd_boris", 74));
			MusiqueSounds.Add (new AudioObj ("C. Project", "cd_cproject", 74));
			MusiqueSounds.Add (new AudioObj ("Royal Gigolos", "cd_royalgigolos", 74));
		}

	}
}