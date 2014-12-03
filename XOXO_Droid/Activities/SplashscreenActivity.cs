
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
	[Activity (Label = "XOXO", Theme = "@style/Theme.Splash", MainLauncher = true, NoHistory = true, Icon="@drawable/xoxo")]			
	public class SplashscreenActivity : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			StartActivity(typeof(MenuActivity));
			// Create your application here
		}
	}
}

