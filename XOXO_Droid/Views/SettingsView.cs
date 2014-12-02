
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace XOXO_Droid
{
	[Activity (Label = "Settings", ScreenOrientation = Android.Content.PM.ScreenOrientation.Portrait, Icon = "@drawable/Icon")]			
	public class SettingsView : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			var prefs = Application.Context.GetSharedPreferences ("XOXOPreferences", FileCreationMode.Private);
			var musicPref = prefs.GetBoolean ("musicPref", true);
			MusicEnabled = musicPref;
			var prefEditor = prefs.Edit ();
			SetContentView (Resource.Layout.Settings);
			CheckBox music = FindViewById<CheckBox> (Resource.Id.Music);

			if (MusicEnabled) 
			{
				music.Checked = true;
			} 
			else if (MusicEnabled == false) 
			{
				music.Checked = false;
			}

			music.Click += (object sender, EventArgs e) => {
				if(MusicEnabled)
				{
					prefEditor.PutBoolean("musicPref", false);
					prefEditor.Commit();
					MusicEnabled = false;
				}
				else
				{
					prefEditor.PutBoolean("musicPref", true);
					prefEditor.Commit();
					MusicEnabled = true;
				}
			};

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

