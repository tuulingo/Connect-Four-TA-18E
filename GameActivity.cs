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

namespace Connect_four
{
    [Activity(Label = "GameActivity")]
    public class GameActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.grid_layout);

            // Create your application here

            var gameButton1 = FindViewById<Button>(Resource.Id.gameButton1);
            var gameButton2 = FindViewById<Button>(Resource.Id.gameButton2);
            var gameButton3 = FindViewById<Button>(Resource.Id.gameButton3);
            var gameButton4 = FindViewById<Button>(Resource.Id.gameButton4);
            var gameButton5 = FindViewById<Button>(Resource.Id.gameButton5);
            var gameButton6 = FindViewById<Button>(Resource.Id.gameButton6);
            var gameButton7 = FindViewById<Button>(Resource.Id.gameButton7);


        }
    }
}