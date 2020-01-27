using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Content;
using System;
using static Android.Resource;

namespace Connect_four
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            var p1Color = Resources.GetString(Resource.Color.player1);
            var p2Color = Resources.GetString(Resource.Color.player2);

            var GridA1 = FindViewById<TextView>(Resource.Id.A1);

            var toGameButton = FindViewById<Button>(Resource.Id.toGameButton);

            toGameButton.Click += toGameButton_Click;

            void toGameButton_Click(object sender, EventArgs e)
            {
                var intent = new Intent(this, typeof(GameActivity));
                StartActivity(intent);
            }
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);

        }
    }
}