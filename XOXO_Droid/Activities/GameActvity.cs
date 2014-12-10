
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
	[Activity (Label = "GameActivity", ScreenOrientation = Android.Content.PM.ScreenOrientation.Portrait)]			
	public class GameActivity : Activity
	{
		public int[,] grid = new int[3,3];
		public List<XYCoordonates> coord = new List<XYCoordonates>();
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			SetContentView (Resource.Layout.Game);


			coord.Add (new XYCoordonates (0,0));
			coord.Add (new XYCoordonates (0,1));
			coord.Add (new XYCoordonates (0,2));
			coord.Add (new XYCoordonates (1,0));
			coord.Add (new XYCoordonates (1,1));
			coord.Add (new XYCoordonates (1,2));
			coord.Add (new XYCoordonates (2,0));
			coord.Add (new XYCoordonates (2,1));
			coord.Add (new XYCoordonates (2,2));

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
			int count = 0;
			foreach (Button button in buttonList) {
				button.Id = count;
				button.Click += (object sender, EventArgs e) => {
					int x = coord[button.Id].X;
					int y = coord[button.Id].Y;
					if(Turn == false)	{
						var drawCross  = Resources.GetDrawable(Resource.Drawable.cross);
						button.SetBackgroundDrawable(drawCross);
						button.Enabled = false;
						grid[x, y] = 1;
					}
					else {
						var drawCircle = Resources.GetDrawable(Resource.Drawable.circle);
						button.SetBackgroundDrawable(drawCircle);
						button.Enabled = false;
						grid[x, y] = 2;
					}
					var result = CheckWin();
					_turn = !_turn;
				};	
				count++;
			}
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
		public class XYCoordonates{
			public int X;
			public int Y;

			public XYCoordonates(int x, int y)
			{
				X = x;
				Y = y;
			}

		}
		public int CheckWin()
		{
			int victory = 0;
			for(int i = 0; i < 3; i++)
			{
				for (int j = 0; j < 3; j++)
				{
					victory += grid [i, j];
					if (victory == 3 || victory == 6) {
						return victory;
					}

				}        
			}
			return victory;
		}
	}
}

