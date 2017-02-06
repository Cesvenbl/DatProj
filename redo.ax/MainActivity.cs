using System.Timers;
using System;
using System.Threading;

using Android.App;
using Android.Widget;
using Android.OS;


namespace redo.ax
{
	[Activity(Label = "redo.ax", MainLauncher = true, Icon = "@drawable/logo")]
	public class MainActivity : Activity
	{
		//int count = 1;

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.Login);

			// Get our button from the layout resource,
			// and attach an event to it
			Button button = FindViewById<Button>(Resource.Id.myButton);
			TextView textview = FindViewById<TextView>(Resource.Id.timerValue);

			button.Click += delegate { SetContentView(Resource.Layout.Main); };

			ThreadPool.QueueUserWorkItem (o => toimer());

		}

		public static System.Timers.Timer aTimer;

		public static void toimer() {
			//en timer med en sekunds interval
			aTimer = new System.Timers.Timer(1000);
			aTimer.Elapsed += OnTimedEvent;
			aTimer.Enabled = true;

		}

		static void OnTimedEvent(object sender, ElapsedEventArgs e)
		{

			RunOnUiThread(() => textview.text();
		}
	
	}
}

