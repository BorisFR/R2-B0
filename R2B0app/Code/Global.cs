using System;
using System.Collections.ObjectModel;
using Plugin.Vibrate;
using Xamarin.Forms;
//using Xam.Plugins.Vibrate;
using Plugin.Vibrate.Abstractions;

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

		public static bool IsPlaying = false;
		public static bool IsStop = true;

		public static bool Disco = false;
		public static bool BallOpen = false;
		public static bool BallTurn = false;
		public static bool PiePanelsOpen = false;
		public static bool PiePanelLight = false;
		public static bool SyncLights = false;

		public static string IpAddress = "192.168.4.1";

		public static R2B0appPage MainPage;

		public static IVibrate Vibrate;

		public static ObservableCollection<TestObj> AllMenu = new ObservableCollection<TestObj> ();
		public static ObservableCollection<AudioObj> R2sounds = new ObservableCollection<AudioObj> ();
		public static ObservableCollection<AudioObj> StarWarsSounds = new ObservableCollection<AudioObj> ();
		public static ObservableCollection<AudioObj> SeriesSounds = new ObservableCollection<AudioObj> ();
		public static ObservableCollection<AudioObj> MusiqueSounds = new ObservableCollection<AudioObj> ();

		public static void Init ()
		{
			Vibrate = CrossVibrate.Current;

			AllMenu.Add (new TestObj ("R2 sound", FAIcon.Bullhorn, Screen.R2Sound));
			AllMenu.Add (new TestObj ("Star Wars", FAIcon.Rebel, Screen.StarWars));
			AllMenu.Add (new TestObj ("Movie", FAIcon.Film, Screen.SeriesTV));
			AllMenu.Add (new TestObj ("Music", FAIcon.Music, Screen.Musique));
			AllMenu.Add (new TestObj ("Settings", FAIcon.Cogs, Screen.Settings));
			AllMenu.Add (new TestObj ("Disco", FAIcon.Ball, Screen.Disco));

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

			StarWarsSounds.Add (new AudioObj ("Star Wars Theme", FAIcon.Empire, 5, 50));
			StarWarsSounds.Add (new AudioObj ("Marche Imperiale", FAIcon.Empire, 5, 51));
			StarWarsSounds.Add (new AudioObj ("Battle of the Heroes", FAIcon.Empire, 5, 52));
			StarWarsSounds.Add (new AudioObj ("La Cantina", FAIcon.Rebel, 5, 53));
			StarWarsSounds.Add (new AudioObj ("Message de Leia", FAIcon.Rebel, 9, 97));

			StarWarsSounds.Add (new AudioObj ("Birthday", FAIcon.Empire, 5, 1));
			StarWarsSounds.Add (new AudioObj ("Gangnam Style", FAIcon.Empire, 5, 2));
			StarWarsSounds.Add (new AudioObj ("Harlem Shake", FAIcon.Empire, 5, 3));
			StarWarsSounds.Add (new AudioObj ("In Love", FAIcon.Empire, 5, 4));
			StarWarsSounds.Add (new AudioObj ("Macho Man", FAIcon.Empire, 5, 5));
			StarWarsSounds.Add (new AudioObj ("Mahna Mahna", FAIcon.Empire, 5, 6));
			StarWarsSounds.Add (new AudioObj ("Peanut Butter Jelly Time", FAIcon.Empire, 5, 7));
			StarWarsSounds.Add (new AudioObj ("Stayin' Alive", FAIcon.Empire, 5, 8));

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

			MusiqueSounds.Add (new AudioObj ("Boris", "cd_boris_soireedisco", 9, 0)); // 74));

			MusiqueSounds.Add (new AudioObj ("Bonnie Tyler", "cd_bonnietyler_totaleclipse", 7, 2));
			MusiqueSounds.Add (new AudioObj ("David Bowie", "cd_davidbowie_underpressure", 7, 4));
			MusiqueSounds.Add (new AudioObj ("Depeche Mode", "cd_depechemode_justcantgetenough", 7, 5));
			MusiqueSounds.Add (new AudioObj ("FGTH", "cd_fgth_relax", 7, 10));
			MusiqueSounds.Add (new AudioObj ("Genesis", "cd_genesis_mama", 7, 11));
			MusiqueSounds.Add (new AudioObj ("INXS", "cd_inxs_needyoutonight", 7, 14));
			MusiqueSounds.Add (new AudioObj ("Marilyn Manson", "cd_marilynmanson_personaljesus", 7, 18));
			MusiqueSounds.Add (new AudioObj ("Nirvana", "cd_nirvana_smellliketenspirit", 7, 21));
			MusiqueSounds.Add (new AudioObj ("Simple Minds", "cd_simpleminds_alivekicking", 7, 29));
			MusiqueSounds.Add (new AudioObj ("Soft Cell", "cd_softcell_taintedlove", 7, 30));
			MusiqueSounds.Add (new AudioObj ("Tears For Fears", "cd_tearsforfears_shout", 7, 31));
			MusiqueSounds.Add (new AudioObj ("The Cure", "cd_thecure_lullaby", 7, 33));
			MusiqueSounds.Add (new AudioObj ("The Eagles", "cd_eagles_hotelcalifornia", 7, 34));
			MusiqueSounds.Add (new AudioObj ("The Police", "cd_police_roxanne", 7, 35));
			MusiqueSounds.Add (new AudioObj ("U2 - Sunday Bloody Sunday", "cd_u2_bloodysunday", 7, 38));
			MusiqueSounds.Add (new AudioObj ("U2 - New Year's Day", "cd_u2_newyearsday", 7, 37));
			MusiqueSounds.Add (new AudioObj ("U2 - With Or Without You", "cd_u2_withorwithoutyou", 7, 39));

			MusiqueSounds.Add (new AudioObj ("Prodigy", "cd_prodigy_smackmybitchup", 7, 25));
			MusiqueSounds.Add (new AudioObj ("Run DMC", "cd_rundmc_itslikethat", 7, 28));

			MusiqueSounds.Add (new AudioObj ("Moby", "cd_moby_naturalblues", 7, 20));
			MusiqueSounds.Add (new AudioObj ("The Black Eyed Peas", "cd_blackeyedpeas_igottafeeling", 7, 32));
			MusiqueSounds.Add (new AudioObj ("Underdog Project vs Sunclub - Summer Jam 2003", "cd_underdogproject_summerjam2003", 7, 40));

			MusiqueSounds.Add (new AudioObj ("Patrick Coutin", "cd_patrickcoutin_jaimeregarderlesfilles", 7, 23));

			MusiqueSounds.Add (new AudioObj ("Benny Benassi", "cd_bennybenassi_californiadreamin", 7, 0));
			MusiqueSounds.Add (new AudioObj ("C. Project", "cd_cproject_morning", 7, 3));
			MusiqueSounds.Add (new AudioObj ("Duke Sauce", "cd_ducksauce_barbarastreisand", 7, 6));
			MusiqueSounds.Add (new AudioObj ("Junior Jack", "cd_juniorjack_dahype", 7, 15));
			MusiqueSounds.Add (new AudioObj ("Kid Cudi", "cd_kidcudi_pursuitofhappiness", 7, 16));
			MusiqueSounds.Add (new AudioObj ("Martin Garrix", "cd_martingarrix_tsunami", 7, 19));
			MusiqueSounds.Add (new AudioObj ("R3hab & KSHMR", "cd_r3hab_karate", 7, 27));
			MusiqueSounds.Add (new AudioObj ("Timmy Trumpet", "cd_timmytrompet_freaks", 7, 36));

			MusiqueSounds.Add (new AudioObj ("Bomb the Bass", "cd_beatdis_bombthebass", 7, 1));
			MusiqueSounds.Add (new AudioObj ("Eric B & Rakim", "cd_ericbrakim_paidinfull", 7, 7));
			MusiqueSounds.Add (new AudioObj ("FPI Project", "cd_fpiproject_richinparadise", 7, 8));
			MusiqueSounds.Add (new AudioObj ("Royal Gigolos", "cd_royalgigolos_californiadreamin", 7, 9));
			MusiqueSounds.Add (new AudioObj ("Grauzone", "cd_grauzone_eisbar", 7, 12));
			MusiqueSounds.Add (new AudioObj ("Herbie Hancock", "cd_herbiehancock_rockit", 7, 13));
			MusiqueSounds.Add (new AudioObj ("Lil Louis", "cd_lillouis_frenchkiss", 7, 17));
			MusiqueSounds.Add (new AudioObj ("One Phat Deeva", "cd_onephatdeeva_inandoutofmylife", 7, 22));
			MusiqueSounds.Add (new AudioObj ("Paul Oakenfold", "cd_housenation", 7, 24));
			MusiqueSounds.Add (new AudioObj ("Push", "cd_push_universalnation", 7, 26));



		}

	}
}