using Android.App;
using Android.Widget;
using Android.OS;

namespace DMhelper
{
	[Activity(Label = "DM helper", MainLauncher = true)]
	public class MainActivity : Activity
	{
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			// Set our view from the "main" layout resource
			// SetContentView (Resource.Layout.YourMainView);
		}
	}
}


