using Android.App;
using Android.Widget;
using Android.OS;

namespace HelloXamarin
{
	[Activity (Label = "HelloXamarin", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{
		Button load_button;
		EditText messageText;

		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it

			load_button = FindViewById<Button> (Resource.Id.load_button);
			messageText = FindViewById<EditText>(Resource.Id.message);

			load_button.Click += delegate {
				Toast.MakeText(Application, messageText.Text, ToastLength.Short).Show();
			};
		}
	}
}


