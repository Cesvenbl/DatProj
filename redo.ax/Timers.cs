
using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace redo.ax
{
	
	[Activity(Label = "Timers")]
	public class Timers : Activity
	{
		

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);
			//hittar Knappen med id startButton
			Button knapp = FindViewById<Button>(Resource.Id.startButton);
			//gör en ny timer instans
			Timer timer = new Timer();
			Timerfunction(knapp, timer);

		}

		static void Timerfunction(Button knapp, Timer timer)
		{
			knapp.Click += delegate
			{
				timer.Start();
			};
		}
	}
}
