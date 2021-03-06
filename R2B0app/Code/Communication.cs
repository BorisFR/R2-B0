﻿using System;
using System.Net.Http;

namespace R2B0app
{
	public delegate void Received (string value);

	public static class Communication
	{
		public static event Received Received;
		public static event Received ReceivedError;

		private static HttpClient httpClient;

		public static void Init ()
		{
			if (httpClient != null) return;
			httpClient = new HttpClient ();
			httpClient.Timeout = new TimeSpan (0, 0, 0, 1, 500);
			httpClient.BaseAddress = new Uri ($"http://{Global.IpAddress}/");
		}

		public async static void SendCommand (string command)
		{
			Init ();
			Global.ForBinding.StartSending ();
			try {
				System.Diagnostics.Debug.WriteLine ("sending " + command);
				string res = await httpClient.GetStringAsync (command);
				Global.ForBinding.StopSending ();
				System.Diagnostics.Debug.WriteLine ("sending OK: " + res);
				if (Received != null)
					Received (res);
			} catch (Exception err) {
				Global.ForBinding.ErrorSending (err.Message);
				if (ReceivedError != null)
					ReceivedError (command);
				System.Diagnostics.Debug.WriteLine ("sending error: " + err.Message);

			}
		}

		public static void SendCommand (R2Command command, int var, int var2 = 0)
		{
			string action = string.Empty;
			string p1 = "0";
			string p2 = "0";
			switch (command) {

			// S = gestion de la carte en elle-meme
			case R2Command.AudioMuteOn:
				action = "S"; p2 = "4"; break;
			case R2Command.AudioMuteOff:
				action = "S"; p2 = "5"; break;
			case R2Command.AudioStop:
				action = "S"; break;
			case R2Command.VolumeDown:
				action = "S"; p2 = "2"; break;
			case R2Command.VolumeUp:
				action = "S"; p2 = "1"; break;
			case R2Command.VolumeSet:
				action = "S"; p2 = "3"; p1 = var.ToString (); break;
			case R2Command.MusicPause:
				action = "S"; p2 = "6"; break;
			case R2Command.MusicResume:
				action = "S"; p2 = "7"; break;

			// R = gestion du bruitage automatique de R2-D2
			case R2Command.BruitageOff:
				action = "R"; break;
			case R2Command.BruitageOn:
				action = "R"; p1 = "1"; break;
			case R2Command.BruitageFrequence:
				action = "R"; p1 = "2"; p2 = var.ToString (); break;

			// A = gestion des bruitages de R2-D2
			case R2Command.PlayR2Sound:
				action = "A"; p2 = var.ToString (); break;
			case R2Command.PlayMusicSound:
				action = "A"; p2 = var.ToString (); break;

			// T = gestion de la musique
			case R2Command.PlayStarWarsSound:
				action = "T"; p1 = var.ToString (); p2 = var2.ToString (); break;
			case R2Command.PlaySerieSound:
				action = "T"; p1 = var.ToString (); p2 = var2.ToString (); break;

			// P = Panels
			case R2Command.PlayPanel:
				action = "P"; p1 = var.ToString (); break;

			// M = Lights
			case R2Command.PlayLight:
				action = "M"; p1 = var.ToString (); break;

			// D = gestion de la partie "boule à facettes"
			case R2Command.DiscoOff:
				action = "D"; break;
			case R2Command.DiscoOn:
				action = "D"; p1 = "1"; break;
			case R2Command.BallIn:
				action = "D"; p1 = "2"; break;
			case R2Command.BallOut:
				action = "D"; p1 = "3"; break;
			case R2Command.BallRotateOff:
				action = "D"; p1 = "4"; break;
			case R2Command.BallRotateOn:
				action = "D"; p1 = "5"; break;
			case R2Command.PiePanelsClose:
				action = "D"; p1 = "6"; break;
			case R2Command.PiePanelsOpen:
				action = "D"; p1 = "7"; break;
			case R2Command.PiePanelsLightOff:
				action = "D"; p1 = "8"; break;
			case R2Command.PiePanelsLightOn:
				action = "D"; p1 = "9"; break;
			case R2Command.SyncLightsOff:
				action = "D"; p1 = "10"; break;
			case R2Command.SyncLightsOn:
				action = "D"; p1 = "11"; break;

			// H = gestion des lumières de la tête
			case R2Command.HpOff:
				action = "H"; break;
			case R2Command.HpOn:
				action = "H"; p1 = "1"; break;
			case R2Command.PsiOff:
				action = "H"; p1 = "2"; break;
			case R2Command.PsiOn:
				action = "H"; p1 = "3"; break;
			case R2Command.FRldOff:
				action = "H"; p1 = "4"; break;
			case R2Command.FRldOn:
				action = "H"; p1 = "5"; break;
			case R2Command.MagicPanelOff:
				action = "H"; p1 = "6"; break;
			case R2Command.MagicPanelOn:
				action = "H"; p1 = "7"; break;

			// F = gestion des trucs du Frame
			case R2Command.LdpOff:
				action = "F"; break;
			case R2Command.LdpOn:
				action = "F"; p1 = "1"; break;


			}
			SendCommand ($"command?action={action}&p1={p1}&p2={p2}");
		}

		public static void SendCommand (R2Command command)
		{
			SendCommand (command, 0);
		}


	}
}