using System;
using System.ComponentModel;
using System.Collections.ObjectModel;

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
				Communication.SendCommand (R2Command.AudioMute);
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