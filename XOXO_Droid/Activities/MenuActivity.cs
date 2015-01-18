
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.Media;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace XOXO_Droid
{
	[Activity (Label = "MenuView", Theme="@android:style/Theme.Translucent.NoTitleBar.Fullscreen", ScreenOrientation = Android.Content.PM.ScreenOrientation.Portrait)]			
	public class MenuActivity : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			var prefs = Application.Context.GetSharedPreferences ("XOXOPreferences", FileCreationMode.Private);
			var musicPref = prefs.GetBoolean ("musicPref", true);
			MusicEnabled = musicPref;
			SetContentView (Resource.Layout.Menu);
			if (MusicEnabled) {
				Player = MediaPlayer.Create (this, Resource.Raw.menu);
			}

			Button multi = FindViewById<Button> (Resource.Id.Multi);
			multi.Click += (object sender, EventArgs e) => {
				StartActivity(typeof(MultiActivity));
			};

			Button settings = FindViewById<Button> (Resource.Id.Settings);
			settings.Click += (object sender, EventArgs e) => {
				if(MusicEnabled && Player != null)
				{
					Player.Pause();	
				}
				StartActivity(typeof(SettingsActivity));
			};

			/*var browser = new Dolphins.Salaam.SalaamBrowser();

			Button multi = FindViewById<Button> (Resource.Id.Multi);
			multi.Click += (object sender, EventArgs e) => {
				var service = new Dolphins.Salaam.SalaamService("_XOXO._tcp","XOXO", 2000);
				service.Register();
				browser.Start("_XOXO._tcp");
			};

			browser.ClientAppeared += (object sender, Dolphins.Salaam.SalaamClientEventArgs e) => {
				AlertDialog.Builder builder = new AlertDialog.Builder(this);
				builder.SetTitle("YAY");
				builder.SetMessage("Client apparus!");
				builder.SetCancelable(false);
				builder.SetPositiveButton("Continue", delegate { Finish(); });
				builder.Show();
			};*/

			Button play = FindViewById<Button> (Resource.Id.Play);
			play.Click += (object sender, EventArgs e) => {
				StartActivity(typeof(GameActivity));
			};
		}

		#region Resume
		protected override void OnResume ()
		{
			var prefs = Application.Context.GetSharedPreferences ("XOXOPreferences", FileCreationMode.Private);
			var musicPref = prefs.GetBoolean ("musicPref", true);
			if (musicPref) {
				if(MusicStoped)
				{
					Player = MediaPlayer.Create (this, Resource.Raw.menu);
					MusicStoped = false;
				}
				if(Player != null){
					Player.Start ();
				} else {
					Player = MediaPlayer.Create (this, Resource.Raw.menu);
				}
				MusicEnabled = musicPref;
			}
			else
			{
				if(Player != null)
				{
					Player.Stop ();
					MusicStoped = true;
				}
			}
			base.OnResume ();
		}
		#endregion

		#region Properties
		private MediaPlayer _player;
		public MediaPlayer Player
		{
			get{ return _player; }
			set 
			{
				if(value != _player)
				{
					_player = value;
				}
			}
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
		private bool _musicStoped;
		public bool MusicStoped
		{
			get{ return _musicStoped; }
			set
			{
				if(value != _musicStoped)
				{
					_musicStoped = value;
				}
			}
		}
		#endregion
	}
}

