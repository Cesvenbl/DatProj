using Android.App;
using Android.Widget;
using Android.OS;

namespace redo.ax
{
	[Activity(Label = "redo.ax", MainLauncher = true, Icon = "@drawable/icon")]
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

			button.Click += delegate { SetContentView(Resource.Layout.Main); };
		}
	}
}

