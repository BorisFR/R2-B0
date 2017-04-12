using System;
using System.ComponentModel;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace R2B0app
{
	public class ForBinding : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;


		public int Volume {
			get {
				return Global.Volume;
			}

			set {
				if (Global.Volume == value) return;
				if (value < 0 || value > 80) return;
				Global.Volume = value;
				Communication.SendCommand (R2Command.VolumeSet, Global.Volume);
				OnPropertyChanged ("Volume");
			}
		}

		public int FrequenceBruitage {
			get {
				return Global.FrequenceBruitage;
			}

			set {
				if (Global.FrequenceBruitage == value) return;
				Global.FrequenceBruitage = value;
				Communication.SendCommand (R2Command.BruitageFrequence, Global.FrequenceBruitage);
				OnPropertyChanged ("FrequenceBruitage");
			}
		}

		public bool UnMute {
			get {
				return Global.Mute;
			}

			set {
				if (Global.Mute == value) return;
				Global.Mute = value;
				if (Global.Mute)
					Communication.SendCommand (R2Command.AudioMuteOn);
				else
					Communication.SendCommand (R2Command.AudioMuteOff);
				OnPropertyChanged ("UnMute");
			}
		}

		public bool RandomBruitage {
			get {
				return Global.RandomBruitage;
			}

			set {
				if (Global.RandomBruitage == value) return;
				Global.RandomBruitage = value;
				if (Global.RandomBruitage)
					Communication.SendCommand (R2Command.BruitageOn);
				else
					Communication.SendCommand (R2Command.BruitageOff);
				OnPropertyChanged ("RandomBruitage");
			}
		}

		public Color ColorPlaying {
			get {
				if (Global.IsStop)
					return Color.Gray;
				return Color.Black;
			}
		}

		public bool IsStop {
			get { return Global.IsStop; }
			set {
				if (Global.IsStop == value) return;
				Global.IsStop = value;
				if (Global.IsStop)
					IsPlaying = false;
				OnPropertyChanged ("IsStop");
				OnPropertyChanged ("ColorPlaying");
			}
		}

		public string PlayPause {
			get {
				if (Global.IsPlaying)
					return FAIcon.Pause;
				return FAIcon.Play;
			}
		}

		public bool IsPlaying {
			get { return Global.IsPlaying; }
			set {
				if (Global.IsPlaying == value) return;
				Global.IsPlaying = value;
				if (Global.IsPlaying)
					IsStop = false;
				OnPropertyChanged ("IsPlaying");
				OnPropertyChanged ("PlayPause");
			}
		}



		public bool BallOpen {
			get { return Global.BallOpen; }
			set {
				if (Global.BallOpen == value) return;
				Global.BallOpen = value;
				if (Global.BallOpen)
					Communication.SendCommand (R2Command.BallOut);
				else
					Communication.SendCommand (R2Command.BallIn);
				OnPropertyChanged ("BallOpen");
				CheckDisco ();
			}
		}

		public bool BallTurn {
			get { return Global.BallTurn; }
			set {
				if (Global.BallTurn == value) return;
				Global.BallTurn = value;
				if (Global.BallTurn)
					Communication.SendCommand (R2Command.BallRotateOn);
				else
					Communication.SendCommand (R2Command.BallRotateOff);
				OnPropertyChanged ("BallTurn");
				CheckDisco ();
			}
		}

		public bool PiePanelsOpen {
			get { return Global.PiePanelsOpen; }
			set {
				if (Global.PiePanelsOpen == value) return;
				Global.PiePanelsOpen = value;
				if (Global.PiePanelsOpen)
					Communication.SendCommand (R2Command.PiePanelsOpen);
				else
					Communication.SendCommand (R2Command.PiePanelsClose);
				OnPropertyChanged ("PiePanelsOpen");
				CheckDisco ();
			}
		}

		public bool PiePanelLight {
			get { return Global.PiePanelLight; }
			set {
				if (Global.PiePanelLight == value) return;
				Global.PiePanelLight = value;
				if (Global.PiePanelLight)
					Communication.SendCommand (R2Command.PiePanelsLightOn);
				else
					Communication.SendCommand (R2Command.PiePanelsLightOff);
				OnPropertyChanged ("PiePanelLight");
				CheckDisco ();
			}
		}

		public bool SyncLights {
			get { return Global.SyncLights; }
			set {
				if (Global.SyncLights == value) return;
				Global.SyncLights = value;
				if (Global.SyncLights)
					Communication.SendCommand (R2Command.SyncLightsOn);
				else
					Communication.SendCommand (R2Command.SyncLightsOff);
				OnPropertyChanged ("SyncLights");
				CheckDisco ();
			}
		}


		private void CheckDisco ()
		{
			if (Global.BallOpen && Global.BallTurn && Global.PiePanelsOpen && Global.PiePanelLight && Global.SyncLights) {
				if (!Global.Disco) {
					Global.Disco = true;
					OnPropertyChanged ("Disco");
				}
			}
			if (!Global.BallOpen || !Global.BallTurn || !Global.PiePanelsOpen || !Global.PiePanelLight || !Global.SyncLights) {
				if (Global.Disco) {
					Global.Disco = false;
					OnPropertyChanged ("Disco");
				}
			}
		}

		public bool Disco {
			get { return Global.Disco; }
			set {
				if (Global.Disco == value) return;
				Global.Disco = value;
				if (Global.Disco)
					Communication.SendCommand (R2Command.DiscoOn);
				else
					Communication.SendCommand (R2Command.DiscoOff);
				Global.BallOpen = value;
				Global.BallTurn = value;
				Global.PiePanelsOpen = value;
				Global.PiePanelLight = value;
				Global.SyncLights = value;
				OnPropertyChanged ("BallOpen");
				OnPropertyChanged ("BallTurn");
				OnPropertyChanged ("PiePanelsOpen");
				OnPropertyChanged ("PiePanelLight");
				OnPropertyChanged ("SyncLights");
				OnPropertyChanged ("Disco");
			}
		}



		public int SendCommand {
			get { return Global.sendCommand; }
			set {
				if (Global.sendCommand == value) return;
				Global.sendCommand = value; OnPropertyChanged ("SendCommand");
			}
		}

		public int SendingCommandStatus {
			get { return Global.sendingCommand; }
			set {
				if (Global.sendingCommand == value) return;
				Global.sendingCommand = value; OnPropertyChanged ("SendingCommandStatus"); OnPropertyChanged ("SendingCommandStatusSource");
			}
		}

		public int SendCommandOk {
			get { return Global.sendCommandOk; }
			set {
				if (Global.sendCommandOk == value) return;
				Global.sendCommandOk = value; OnPropertyChanged ("SendCommandOk");
			}
		}

		public string LastErrorMessage {
			get { return Global.lastErrorMessage; }
			set {
				if (Global.lastErrorMessage == value) return;
				Global.lastErrorMessage = value; OnPropertyChanged ("LastErrorMessage");
			}
		}

		public void StartSending ()
		{
			SendingCommandStatus = 1;
			SendCommand = Global.sendCommand + 1;
		}

		public void StopSending ()
		{
			SendingCommandStatus = 0;
			SendCommandOk = Global.sendCommandOk + 1;
		}

		public void ErrorSending (string error)
		{
			LastErrorMessage = error;
			SendingCommandStatus = -5;
		}




		protected virtual void OnPropertyChanged (string propertyName)
		{
			if (PropertyChanged != null) {
				PropertyChanged (this,
					new PropertyChangedEventArgs (propertyName));
			}
		}

	}
}