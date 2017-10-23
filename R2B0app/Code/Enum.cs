using System;
namespace R2B0app
{


	public enum R2Command
	{
		AudioMuteOn,
		AudioMuteOff,
		VolumeUp,
		VolumeDown,
		VolumeSet,
		AudioStop,
		BruitageOn,
		BruitageOff,
		BruitageFrequence,
		PlayR2Sound,
		PlayStarWarsSound,
		PlayMusicSound,
		PlaySerieSound,
		MusicPause,
		MusicResume,
		BallOut,
		BallIn,
		BallRotateOn,
		BallRotateOff,
		PlayPanel,
		PlayLight,
		PiePanelsOpen,
		PiePanelsClose,
		PiePanelsLightOn,
		PiePanelsLightOff,
		SyncLightsOn,
		SyncLightsOff,
		DiscoOn,
		DiscoOff,
		HpOn,
		HpOff,
		PsiOn,
		PsiOff,
		FRldOn,
		FRldOff,
		MagicPanelOn,
		MagicPanelOff,
		LdpOn,
		LdpOff
	}


	public enum Screen
	{
		Menu,
		Settings,
		R2Sound,
		StarWars,
		SeriesTV,
		Musique,
		Disco,
		Panels,
		Lights
	}

}