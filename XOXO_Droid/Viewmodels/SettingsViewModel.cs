using System;

namespace XOXO_Droid
{
	class SettingsViewModel
	{


		public SettingsViewModel ()
		{
			MusicEnabled = true;
		}

		private bool _musicEnabled;
		public bool MusicEnabled
		{
			get{ return _musicEnabled; }
			set
			{
				if(value != _musicEnabled)
				{
					_musicEnabled = value;
				}
			}
		}
	}
}

