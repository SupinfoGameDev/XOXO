
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
	[Activity (Label = "GameView")]			
	public class GameView : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			SetContentView (Resource.Layout.Game);
			Button case1 = FindViewById<Button> (Resource.Id.Button1);
			case1.Click += (object sender, EventArgs e) => {
				var drawable = GetDrawable(Resource.Drawable.cross);
				case1.SetBackgroundDrawable(drawable);
			};
			// Create your application here
		}
	}
}

