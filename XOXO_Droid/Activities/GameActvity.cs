
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

			Button case1 = FindViewById<Button> (Resource.Id.Button1);
			case1.Click += (object sender, EventArgs e) => {
				if(Turn == false) {
					case1.SetBackgroundDrawable(drawCross);
				}
				else {
					case1.SetBackgroundDrawable(drawCircle);
				}
				turn = !turn;

			};

			Button case2 = FindViewById<Button> (Resource.Id.Button2);
			case2.Click += (object sender, EventArgs e) => {
				if(Turn == false)	{
					case2.SetBackgroundDrawable(drawCross);
				}
				else {
					case2.SetBackgroundDrawable(drawCircle);
				}
				turn = !turn;
			};

			Button case3 = FindViewById<Button> (Resource.Id.Button3);
			case3.Click += (object sender, EventArgs e) => {
				if(Turn == false)	{
					case3.SetBackgroundDrawable(drawCross);
				}
				else {
					case3.SetBackgroundDrawable(drawCircle);
				}
				turn = !turn;
			};

			Button case4 = FindViewById<Button> (Resource.Id.Button4);
			case4.Click += (object sender, EventArgs e) => {
				if(Turn == false)	{
					case4.SetBackgroundDrawable(drawCross);
				}
				else {
					case4.SetBackgroundDrawable(drawCircle);
				}
				turn = !turn;
			};

			Button case5 = FindViewById<Button> (Resource.Id.Button5);
			case5.Click += (object sender, EventArgs e) => {
				if(Turn == false)	{
					case5.SetBackgroundDrawable(drawCross);
				}
				else {
					case5.SetBackgroundDrawable(drawCircle);
				}
				turn = !turn;
			};

			Button case6 = FindViewById<Button> (Resource.Id.Button6);
			case6.Click += (object sender, EventArgs e) => {
				if(Turn == false)	{
					case6.SetBackgroundDrawable(drawCross);
				}
				else {
					case6.SetBackgroundDrawable(drawCircle);
				}
				turn = !turn;
			};

			Button case7 = FindViewById<Button> (Resource.Id.Button7);
			case7.Click += (object sender, EventArgs e) => {
				if(Turn == false)	{
					case7.SetBackgroundDrawable(drawCross);
				}
				else {
					case7.SetBackgroundDrawable(drawCircle);
				}
				turn = !turn;
			};

			Button case8 = FindViewById<Button> (Resource.Id.Button8);
			case8.Click += (object sender, EventArgs e) => {
				if(Turn == false)	{
					case8.SetBackgroundDrawable(drawCross);
				}
				else {
					case8.SetBackgroundDrawable(drawCircle);
				}
				turn = !turn;
			};

			Button case9 = FindViewById<Button> (Resource.Id.Button9);
			case9.Click += (object sender, EventArgs e) => {
				if(Turn == false)	{
					case9.SetBackgroundDrawable(drawCross);
				}
				else {
					case9.SetBackgroundDrawable(drawCircle);
				}
				turn = !turn;
			};

		}


		/*
		public static PlayerTurn (arg cases)
		{

		}	*/


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

