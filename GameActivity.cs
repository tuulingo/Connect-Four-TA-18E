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
        private TextView[] aColumn = new TextView[6];
        private TextView[] bColumn = new TextView[6];
        private TextView[] cColumn = new TextView[6];
        private TextView[] dColumn = new TextView[6];
        private TextView[] eColumn = new TextView[6];
        private TextView[] fColumn = new TextView[6];
        private TextView[] gColumn = new TextView[6];
        private Button[] gameButton = new Button[7];
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.grid_layout);
            for (int i = 1; i <= 6; i++)
            {
                var textViewId = $"A{i}";
                var view = FindViewById<TextView>(Resources.GetIdentifier(textViewId, "id", PackageName));
                aColumn[i] = view;
            }

            for (int i = 1; i <= 6; i++)
            {
                var textViewId = $"B{i}";
                var view = FindViewById<TextView>(Resources.GetIdentifier(textViewId, "id", PackageName));
            }

            for (int i = 1; i <= 6; i++)
            {
                var textViewId = $"C{i}";
                var view = FindViewById<TextView>(Resources.GetIdentifier(textViewId, "id", PackageName));
            }

            for (int i = 1; i <= 6; i++)
            {
                var textViewId = $"D{i}";
                var view = FindViewById<TextView>(Resources.GetIdentifier(textViewId, "id", PackageName));
            }

            for (int i = 1; i <= 6; i++)
            {
                var textViewId = $"E{i}";
                var view = FindViewById<TextView>(Resources.GetIdentifier(textViewId, "id", PackageName));
            }

            for (int i = 1; i <= 6; i++)
            {
                var textViewId = $"F{i}";
                var view = FindViewById<TextView>(Resources.GetIdentifier(textViewId, "id", PackageName));
            }

            for (int i = 1; i <= 6; i++)
            {
                var textViewId = $"G{i}";
                var view = FindViewById<TextView>(Resources.GetIdentifier(textViewId, "id", PackageName));
            }

            for (int i = 1; i <= 7; i++)
            {
                var buttonId = $"gameButton{i}";
                var view = FindViewById<Button>(Resources.GetIdentifier(buttonId, "id", PackageName));
            }
            // Create your application here 

            
            

            // gamebuttons
            var gameButton1 = FindViewById<Button>(Resource.Id.gameButton1);
            var gameButton2 = FindViewById<Button>(Resource.Id.gameButton2);
            var gameButton3 = FindViewById<Button>(Resource.Id.gameButton3);
            var gameButton4 = FindViewById<Button>(Resource.Id.gameButton4);
            var gameButton5 = FindViewById<Button>(Resource.Id.gameButton5);
            var gameButton6 = FindViewById<Button>(Resource.Id.gameButton6);
            var gameButton7 = FindViewById<Button>(Resource.Id.gameButton7);

           
        }
        private void OnClick(object sender, EventArgs args)
        {
            if (sender is Button btn)
            {
                var tag = btn.Tag;
                btn.Click += OnClick;
                if (tag == gameButton1)
                {
                   // method
                   // DoSomething();
                }
                else if (tag == gamebutton2)
                {
                   // DoSomethingElse();
                }
            }
        }
    }
}