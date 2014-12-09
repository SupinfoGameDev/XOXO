
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
//using Android.Graphics.Drawables.Drawable;

namespace XOXO_Droid
{
	[Activity (Label = "GameActivity")]			
	public class GameActivity : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			SetContentView (Resource.Layout.Game);

			var drawCross  = Resources.GetDrawable(Resource.Drawable.circle);
			var drawCircle = Resources.GetDrawable(Resource.Drawable.cross);

			List<Button> buttonList = new List<Button>();
			buttonList.Add (FindViewById<Button> (Resource.Id.Button1));
			buttonList.Add (FindViewById<Button> (Resource.Id.Button2));
			buttonList.Add (FindViewById<Button> (Resource.Id.Button3));
			buttonList.Add (FindViewById<Button> (Resource.Id.Button4));
			buttonList.Add (FindViewById<Button> (Resource.Id.Button5));
			buttonList.Add (FindViewById<Button> (Resource.Id.Button6));
			buttonList.Add (FindViewById<Button> (Resource.Id.Button7));
			buttonList.Add (FindViewById<Button> (Resource.Id.Button8));
			buttonList.Add (FindViewById<Button> (Resource.Id.Button9));

			foreach (Button button in buttonList) {
				button.Click += (object sender, EventArgs e) => {
					if(Turn == false)	{
						button.SetBackgroundDrawable(drawCross);
					}
					else {
						button.SetBackgroundDrawable(drawCircle);
					}
					turn = !turn;
				};			
			}
		}

		/*****
		public static void PlayerTurn()
		{
			if(Turn == false) {
				case1.SetBackgroundDrawable(drawCross);
			}
			else {
				case1.SetBackgroundDrawable(drawCircle);
			}
			turn = !turn;
		}	
		*****/

		public override void OnBackPressed ()
		{
			//base.OnBackPressed ();
		}

		private bool turn = false;
		public bool Turn {
			get{ return turn; }
			set 
			{
				if(value != turn)
				{
					turn = value;
				}
			}
		}
	}
}

