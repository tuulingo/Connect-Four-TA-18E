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
        //private TextView[] aColumn = new TextView[6];
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.grid_layout);
            //for (int i = 0; i < 6; i++)
            //{
            //    var textViewID = "A" + i;
            //    aColumn[i] = FindViewById<TextView>();

            //}
            // Create your application here 

            // gamebuttons
            var gameButton1 = FindViewById<Button>(Resource.Id.gameButton1);
            var gameButton2 = FindViewById<Button>(Resource.Id.gameButton2);
            var gameButton3 = FindViewById<Button>(Resource.Id.gameButton3);
            var gameButton4 = FindViewById<Button>(Resource.Id.gameButton4);
            var gameButton5 = FindViewById<Button>(Resource.Id.gameButton5);
            var gameButton6 = FindViewById<Button>(Resource.Id.gameButton6);
            var gameButton7 = FindViewById<Button>(Resource.Id.gameButton7);

            // aColumn
            var A1 = FindViewById<TextView>(Resource.Id.A1);
            var A2 = FindViewById<TextView>(Resource.Id.A2);
            var A3 = FindViewById<TextView>(Resource.Id.A3);
            var A4 = FindViewById<TextView>(Resource.Id.A4);
            var A5 = FindViewById<TextView>(Resource.Id.A5);
            var A6 = FindViewById<TextView>(Resource.Id.A6);

            // bColumn
            var B1 = FindViewById<TextView>(Resource.Id.B1);
            var B2 = FindViewById<TextView>(Resource.Id.B2);
            var B3 = FindViewById<TextView>(Resource.Id.B3);
            var B4 = FindViewById<TextView>(Resource.Id.B4);
            var B5 = FindViewById<TextView>(Resource.Id.B5);
            var B6 = FindViewById<TextView>(Resource.Id.B6);

            // cColumn
            var C1 = FindViewById<TextView>(Resource.Id.C1);
            var C2 = FindViewById<TextView>(Resource.Id.C2);
            var C3 = FindViewById<TextView>(Resource.Id.C3);
            var C4 = FindViewById<TextView>(Resource.Id.C4);
            var C5 = FindViewById<TextView>(Resource.Id.C5);
            var C6 = FindViewById<TextView>(Resource.Id.C6);

            // dColumn
            var D1 = FindViewById<TextView>(Resource.Id.D1);
            var D2 = FindViewById<TextView>(Resource.Id.D2);
            var D3 = FindViewById<TextView>(Resource.Id.D3);
            var D4 = FindViewById<TextView>(Resource.Id.D4);
            var D5 = FindViewById<TextView>(Resource.Id.D5);
            var D6 = FindViewById<TextView>(Resource.Id.D6);

            // eColumn
            var E1 = FindViewById<TextView>(Resource.Id.E1);
            var E2 = FindViewById<TextView>(Resource.Id.E2);
            var E3 = FindViewById<TextView>(Resource.Id.E3);
            var E4 = FindViewById<TextView>(Resource.Id.E4);
            var E5 = FindViewById<TextView>(Resource.Id.E5);
            var E6 = FindViewById<TextView>(Resource.Id.E6);

            // fColumn
            var F1 = FindViewById<TextView>(Resource.Id.F1);
            var F2 = FindViewById<TextView>(Resource.Id.F2);
            var F3 = FindViewById<TextView>(Resource.Id.F3);
            var F4 = FindViewById<TextView>(Resource.Id.F4);
            var F5 = FindViewById<TextView>(Resource.Id.F5);
            var F6 = FindViewById<TextView>(Resource.Id.F6);

            // gColumn
            var G1 = FindViewById<TextView>(Resource.Id.G1);
            var G2 = FindViewById<TextView>(Resource.Id.G2);
            var G3 = FindViewById<TextView>(Resource.Id.G3);
            var G4 = FindViewById<TextView>(Resource.Id.G4);
            var G5 = FindViewById<TextView>(Resource.Id.G5);
            var G6 = FindViewById<TextView>(Resource.Id.G6);

            var whiteOval = Resource.Drawable.

            //gameButton1.Click += (sender, e) => {

            //};
            gameButton1.Click += async delegate
            {

            }
        }
    }
}