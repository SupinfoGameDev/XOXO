
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
			PlayerTurn (buttonList);
		}


		public void PlayerTurn(List<Button> buttonList)
		{
			foreach (Button button in buttonList) {
				button.Click += (object sender, EventArgs e) => {
					if(Turn == false)	{
						var drawCross  = Resources.GetDrawable(Resource.Drawable.cross);
						button.SetBackgroundDrawable(drawCross);
					}
					else {
						var drawCircle = Resources.GetDrawable(Resource.Drawable.circle);
						button.SetBackgroundDrawable(drawCircle);
					}
					_turn = !_turn;
				};			
			}
		}	


		public override void OnBackPressed ()
		{
			//base.OnBackPressed ();
		}

		private bool _turn = false;
		public bool Turn {
			get{ return _turn; }
			set 
			{
				if(value != _turn)
				{
					_turn = value;
				}
			}
		}
	}
}

