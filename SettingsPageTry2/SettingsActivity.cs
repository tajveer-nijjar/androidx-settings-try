using System;
using Android.App;
using Android.OS;
using Android.Runtime;
using Google.Android.Material;
using AndroidX.AppCompat.App;
using AndroidX.Preference;

//using Android.Support.Design.Widget;
//using Android.Support.V7.App;
using Android.Views;
using Android.Widget;
using Google.Android.Material.FloatingActionButton;
using Google.Android.Material.Snackbar;

namespace SettingsPageTry2
{
    [Activity(Label = "SettingsActivity")]
    public class SettingsActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.activity_settings);

            SupportFragmentManager.BeginTransaction().Replace(Resource.Id.frameLayout, new SettingsFragment()).Commit();
        }
    }
}