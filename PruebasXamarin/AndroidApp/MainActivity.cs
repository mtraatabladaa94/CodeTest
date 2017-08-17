using Android.App;
using Android.Widget;
using Android.OS;
using TeipeApp;



namespace AndroidApp
{
    [Activity(Label = "AndroidApp", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {

        Toolbar principalToolbar;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);

            this.setActionBarTheme();

        }

        private void setActionBarTheme()
        {

            this.principalToolbar = FindViewById<Toolbar>(Resource.Id.principalToolBar);

            this.principalToolbar.Title = "Teipe App";

            this.SetActionBar(this.principalToolbar);

        }

    }
}

