using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;


namespace Connect_four
{
    [Activity(Label = "GameActivity")]
    public class GameActivity : Activity 
    {
        private bool player1Turn = true;

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
            for (int i = 0; i < 7; i++)
            {
                var buttonId = $"gameButton{i+1}";
                var view = FindViewById<Button>(Resources.GetIdentifier(buttonId, "id", PackageName));
                gameButton[i] = view;
            }

            for (int i = 0; i < 6; i++)
            {
                var textViewId = $"A{i+1}";
                var view = FindViewById<TextView>(Resources.GetIdentifier(textViewId, "id", PackageName));
                aColumn[i] = view;
            }

            for (int i = 0; i < 6; i++)
            {
                var textViewId = $"B{i+1}";
                var view = FindViewById<TextView>(Resources.GetIdentifier(textViewId, "id", PackageName));
                bColumn[i] = view;
            }

            for (int i = 0; i < 6; i++)
            {
                var textViewId = $"C{i+1}";
                var view = FindViewById<TextView>(Resources.GetIdentifier(textViewId, "id", PackageName));
                cColumn[i] = view;
            }

            for (int i = 0; i < 6; i++)
            {
                var textViewId = $"D{i+1}";
                var view = FindViewById<TextView>(Resources.GetIdentifier(textViewId, "id", PackageName));
                dColumn[i] = view;
            }

            for (int i = 0; i < 6; i++)
            {
                var textViewId = $"E{i+1}";
                var view = FindViewById<TextView>(Resources.GetIdentifier(textViewId, "id", PackageName));
                eColumn[i] = view;
            }

            for (int i = 0; i < 6; i++)
            {
                var textViewId = $"F{i+1}";
                var view = FindViewById<TextView>(Resources.GetIdentifier(textViewId, "id", PackageName));
                fColumn[i] = view;
            }

            for (int i = 0; i < 6; i++)
            {
                var textViewId = $"G{i+1}";
                var view = FindViewById<TextView>(Resources.GetIdentifier(textViewId, "id", PackageName));
                gColumn[i] = view;
            }

            gameButton[0].Click += delegate
            {
                aColumnClick();
            };

            //gameButton[2].Click += delegate
            //{
            //    Toast.MakeText(this, "Hello from " + gameButton[2], ToastLength.Long).Show();
            //};


            // Create your application here 


        }
        private void OnClick(object sender, EventArgs args)
        {
            if (sender is Button btn)
            {
                btn.Click += OnClick;
                var tag = btn;

                if (tag == gameButton[0])
                {
                    aColumnClick();
                }
                else if (tag == gameButton[1])
                {
                    Toast.MakeText(this, "Hello from " , ToastLength.Long).Show();
                }
                else if (tag == gameButton[2])
                {
                    // DoSomethingElse();
                }
                else if (tag == gameButton[3])
                {
                    // DoSomethingElse();
                }
                else if (tag == gameButton[4])
                {
                    // DoSomethingElse();
                }
                else if (tag == gameButton[5])
                {
                    // DoSomethingElse();
                }
                else if (tag == gameButton[6])
                {
                    // DoSomethingElse();
                }
            }
        }

        public void aColumnClick()
        {
            var test = FindViewById<TextView>(Resource.Id.B6);
            var defaultColor = Resources.GetColor(Resource.Color.white);
            var playerColor1 = Resources.GetColor(Resource.Color.player1);
            var playerColor2 = Resources.GetColor(Resource.Color.player2);
            ColorDrawable canvasColor = (ColorDrawable)test.Background;
            int colorId = canvasColor.Color;

            if (aColumn[5].Background != canvasColor)
            {
                if (player1Turn == true)
                {
                    aColumn[5].SetBackgroundColor(playerColor1);
                }
                else
                {
                    aColumn[5].SetBackgroundColor(playerColor2);
                }

            }
            else if (aColumn[4].Background != canvasColor)
            {
                if (player1Turn == true)
                {
                    aColumn[4].SetBackgroundColor(playerColor1);
                }
                else
                {
                    aColumn[4].SetBackgroundColor(playerColor2);
                }

            }

        }
    }
}