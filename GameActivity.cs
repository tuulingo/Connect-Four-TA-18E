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

        private int aClickCounter = 0;
        private int bClickCounter = 0;
        private int cClickCounter = 0;
        private int dClickCounter = 0;
        private int eClickCounter = 0;
        private int fClickCounter = 0;
        private int gClickCounter = 0;

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

            Context context = Application.Context;
            string text = "Column is full";
            ToastLength duration = ToastLength.Short;

            gameButton[0].Click += delegate
            {
                if (aClickCounter < 6)
                {
                    CheckHorizontalWinner();
                    aClickCounter++;
                    aColumnClick();
                    if (player1Turn == true)
                    {
                        player1Turn = false;
                    }
                    else player1Turn = true;
                }
                else
                {
                    var toast = Toast.MakeText(context, text, duration);
                    toast.Show();
                }
            };

            gameButton[1].Click += delegate
            {
                if (bClickCounter < 6)
                {
                    CheckHorizontalWinner();
                    bClickCounter++;
                    bColumnClick();
                    if (player1Turn == true)
                    {
                        player1Turn = false;
                    }
                    else player1Turn = true;
                }
                else
                {
                    var toast = Toast.MakeText(context, text, duration);
                    toast.Show();
                }
            };

            gameButton[2].Click += delegate
            {
                if (cClickCounter < 6)
                {
                    CheckHorizontalWinner();
                    cClickCounter++;
                    cColumnClick();
                    if (player1Turn == true)
                    {
                        player1Turn = false;
                    }
                    else player1Turn = true;
                }
                else
                {
                    var toast = Toast.MakeText(context, text, duration);
                    toast.Show();
                }
            };

            gameButton[3].Click += delegate
            {
                if (dClickCounter < 6)
                {
                    CheckHorizontalWinner();
                    dClickCounter++;
                    dColumnClick();
                    if (player1Turn == true)
                    {
                        player1Turn = false;
                    }
                    else player1Turn = true;
                }
                else
                {
                    var toast = Toast.MakeText(context, text, duration);
                    toast.Show();
                }
            };

            gameButton[4].Click += delegate
            {
                if (eClickCounter < 6)
                {
                    CheckHorizontalWinner();
                    eClickCounter++;
                    eColumnClick();
                    if (player1Turn == true)
                    {
                        player1Turn = false;
                    }
                    else player1Turn = true;
                }
                else
                {
                    var toast = Toast.MakeText(context, text, duration);
                    toast.Show();
                }
            };

            gameButton[5].Click += delegate
            {
                if (fClickCounter < 6)
                {
                    CheckHorizontalWinner();
                    fClickCounter++;
                    fColumnClick();
                    if (player1Turn == true)
                    {
                        player1Turn = false;
                    }
                    else player1Turn = true;
                }
                else
                {
                    var toast = Toast.MakeText(context, text, duration);
                    toast.Show();
                }
            };

            gameButton[6].Click += delegate
            {
                if (gClickCounter < 6)
                {
                    CheckHorizontalWinner();
                    gClickCounter++;
                    gColumnClick();
                    if (player1Turn == true)
                    {
                        player1Turn = false;
                    }
                    else player1Turn = true;
                }
                else
                {
                    var toast = Toast.MakeText(context, text, duration);
                    toast.Show();
                }

            };

        }

        private void CheckHorizontalWinner()
        {
            TextView[,] field = new TextView[6,7];

            Context context = Application.Context;
            string text = "Sen haigemees";
            ToastLength duration = ToastLength.Short;

            var playerColor1 = Resources.GetColor(Resource.Color.player1);
            var playerColor2 = Resources.GetColor(Resource.Color.player2);

            var gridLayout = FindViewById<GridLayout>(Resource.Id.gridLayout);
            var currentColumn = 0;
            var currentRow = 0;
            for (var i = 0; i < 42; i++)
            {
                var child = gridLayout.GetChildAt(i) as TextView;
                field[currentRow, currentColumn] = child;
                ColorDrawable canvasColor = (ColorDrawable)field[currentRow, currentColumn].Background;
                

                currentColumn++;

                if (currentColumn == 7)
                {
                    currentColumn = 0;
                    currentRow++;
                }

                if (field[0,1].Background == playerColor1)
                {
                    var toast = Toast.MakeText(context, text, duration);
                    toast.Show();

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

                if (aColumn[5].Alpha != canvasColor.Alpha)
                {
                    if (player1Turn == true)
                    {
                        aColumn[5].SetBackgroundColor(playerColor1);
                        aColumn[5].Alpha = 255;
                    }
                    else
                    {
                        aColumn[5].SetBackgroundColor(playerColor2);
                        aColumn[5].Alpha = 255;
                    }
                }
                else if (aColumn[4].Alpha != canvasColor.Alpha)
                {
                    if (player1Turn == true)
                    {
                        aColumn[4].SetBackgroundColor(playerColor1);
                        aColumn[4].Alpha = 255;
                    }
                    else
                    {
                        aColumn[4].SetBackgroundColor(playerColor2);
                        aColumn[4].Alpha = 255;
                    }
                }
                else if (aColumn[3].Alpha != canvasColor.Alpha)
                {
                    if (player1Turn == true)
                    {
                        aColumn[3].SetBackgroundColor(playerColor1);
                        aColumn[3].Alpha = 255;
                    }
                    else
                    {
                        aColumn[3].SetBackgroundColor(playerColor2);
                        aColumn[3].Alpha = 255;
                    }

                }
                else if (aColumn[2].Alpha != canvasColor.Alpha)
                {
                    if (player1Turn == true)
                    {
                        aColumn[2].SetBackgroundColor(playerColor1);
                        aColumn[2].Alpha = 255;
                    }
                    else
                    {
                        aColumn[2].SetBackgroundColor(playerColor2);
                        aColumn[2].Alpha = 255;
                    }

                }
                else if (aColumn[1].Alpha != canvasColor.Alpha)
                {
                    if (player1Turn == true)
                    {
                        aColumn[1].SetBackgroundColor(playerColor1);
                        aColumn[1].Alpha = 255;
                    }
                    else
                    {
                        aColumn[1].SetBackgroundColor(playerColor2);
                        aColumn[1].Alpha = 255;
                    }

                }
                else if (aColumn[0].Alpha != canvasColor.Alpha)
                {
                    if (player1Turn == true)
                    {
                        aColumn[0].SetBackgroundColor(playerColor1);
                        aColumn[0].Alpha = 255;
                    }
                    else
                    {
                        aColumn[0].SetBackgroundColor(playerColor2);
                        aColumn[0].Alpha = 255;
                    }

                }
        }

        public void bColumnClick()
        {
            var test = FindViewById<TextView>(Resource.Id.B6);
            var defaultColor = Resources.GetColor(Resource.Color.white);
            var playerColor1 = Resources.GetColor(Resource.Color.player1);
            var playerColor2 = Resources.GetColor(Resource.Color.player2);
            ColorDrawable canvasColor = (ColorDrawable)test.Background;
            int colorId = canvasColor.Color;

                if (bColumn[5].Alpha != canvasColor.Alpha)
                {
                    if (player1Turn == true)
                    {
                        bColumn[5].SetBackgroundColor(playerColor1);
                        bColumn[5].Alpha = 255;
                    }
                    else
                    {
                        bColumn[5].SetBackgroundColor(playerColor2);
                        bColumn[5].Alpha = 255;
                    }
                }
                else if (bColumn[4].Alpha != canvasColor.Alpha)
                {
                    if (player1Turn == true)
                    {
                        bColumn[4].SetBackgroundColor(playerColor1);
                        bColumn[4].Alpha = 255;
                    }
                    else
                    {
                        bColumn[4].SetBackgroundColor(playerColor2);
                        bColumn[4].Alpha = 255;
                    }
                }
                else if (bColumn[3].Alpha != canvasColor.Alpha)
                {
                    if (player1Turn == true)
                    {
                        bColumn[3].SetBackgroundColor(playerColor1);
                        bColumn[3].Alpha = 255;
                    }
                    else
                    {
                        bColumn[3].SetBackgroundColor(playerColor2);
                        bColumn[3].Alpha = 255;
                    }

                }
                else if (bColumn[2].Alpha != canvasColor.Alpha)
                {
                    if (player1Turn == true)
                    {
                        bColumn[2].SetBackgroundColor(playerColor1);
                        bColumn[2].Alpha = 255;
                    }
                    else
                    {
                        bColumn[2].SetBackgroundColor(playerColor2);
                        bColumn[2].Alpha = 255;
                    }

                }
                else if (bColumn[1].Alpha != canvasColor.Alpha)
                {
                    if (player1Turn == true)
                    {
                        bColumn[1].SetBackgroundColor(playerColor1);
                        bColumn[1].Alpha = 255;
                    }
                    else
                    {
                        bColumn[1].SetBackgroundColor(playerColor2);
                        bColumn[1].Alpha = 255;
                    }

                }
                else if (bColumn[0].Alpha != canvasColor.Alpha)
                {
                    if (player1Turn == true)
                    {
                        bColumn[0].SetBackgroundColor(playerColor1);
                        bColumn[0].Alpha = 255;
                    }
                    else
                    {
                        bColumn[0].SetBackgroundColor(playerColor2);
                        bColumn[0].Alpha = 255;
                    }

                }
            
        }

        public void cColumnClick()
        {
            var test = FindViewById<TextView>(Resource.Id.B6);
            var defaultColor = Resources.GetColor(Resource.Color.white);
            var playerColor1 = Resources.GetColor(Resource.Color.player1);
            var playerColor2 = Resources.GetColor(Resource.Color.player2);
            ColorDrawable canvasColor = (ColorDrawable)test.Background;
            int colorId = canvasColor.Color;

                if (cColumn[5].Alpha != canvasColor.Alpha)
                {
                    if (player1Turn == true)
                    {
                        cColumn[5].SetBackgroundColor(playerColor1);
                        cColumn[5].Alpha = 255;
                    }
                    else
                    {
                        cColumn[5].SetBackgroundColor(playerColor2);
                        cColumn[5].Alpha = 255;
                    }
                }
                else if (cColumn[4].Alpha != canvasColor.Alpha)
                {
                    if (player1Turn == true)
                    {
                        cColumn[4].SetBackgroundColor(playerColor1);
                        cColumn[4].Alpha = 255;
                    }
                    else
                    {
                        cColumn[4].SetBackgroundColor(playerColor2);
                        cColumn[4].Alpha = 255;
                    }
                }
                else if (cColumn[3].Alpha != canvasColor.Alpha)
                {
                    if (player1Turn == true)
                    {
                        cColumn[3].SetBackgroundColor(playerColor1);
                        cColumn[3].Alpha = 255;
                    }
                    else
                    {
                        cColumn[3].SetBackgroundColor(playerColor2);
                        cColumn[3].Alpha = 255;
                    }

                }
                else if (cColumn[2].Alpha != canvasColor.Alpha)
                {
                    if (player1Turn == true)
                    {
                        cColumn[2].SetBackgroundColor(playerColor1);
                        cColumn[2].Alpha = 255;
                    }
                    else
                    {
                        cColumn[2].SetBackgroundColor(playerColor2);
                        cColumn[2].Alpha = 255;
                    }

                }
                else if (cColumn[1].Alpha != canvasColor.Alpha)
                {
                    if (player1Turn == true)
                    {
                        cColumn[1].SetBackgroundColor(playerColor1);
                        cColumn[1].Alpha = 255;
                    }
                    else
                    {
                        cColumn[1].SetBackgroundColor(playerColor2);
                        cColumn[1].Alpha = 255;
                    }

                }
                else if (cColumn[0].Alpha != canvasColor.Alpha)
                {
                    if (player1Turn == true)
                    {
                        cColumn[0].SetBackgroundColor(playerColor1);
                        cColumn[0].Alpha = 255;
                    }
                    else
                    {
                        cColumn[0].SetBackgroundColor(playerColor2);
                        cColumn[0].Alpha = 255;
                    }

                }
            
        }

        public void dColumnClick()
        {
            var test = FindViewById<TextView>(Resource.Id.B6);
            var defaultColor = Resources.GetColor(Resource.Color.white);
            var playerColor1 = Resources.GetColor(Resource.Color.player1);
            var playerColor2 = Resources.GetColor(Resource.Color.player2);
            ColorDrawable canvasColor = (ColorDrawable)test.Background;
            int colorId = canvasColor.Color;

                if (dColumn[5].Alpha != canvasColor.Alpha)
                {
                    if (player1Turn == true)
                    {
                        dColumn[5].SetBackgroundColor(playerColor1);
                        dColumn[5].Alpha = 255;
                    }
                    else
                    {
                        dColumn[5].SetBackgroundColor(playerColor2);
                        dColumn[5].Alpha = 255;
                    }
                }
                else if (dColumn[4].Alpha != canvasColor.Alpha)
                {
                    if (player1Turn == true)
                    {
                        dColumn[4].SetBackgroundColor(playerColor1);
                        dColumn[4].Alpha = 255;
                    }
                    else
                    {
                        dColumn[4].SetBackgroundColor(playerColor2);
                        dColumn[4].Alpha = 255;
                    }
                }
                else if (dColumn[3].Alpha != canvasColor.Alpha)
                {
                    if (player1Turn == true)
                    {
                        dColumn[3].SetBackgroundColor(playerColor1);
                        dColumn[3].Alpha = 255;
                    }
                    else
                    {
                        dColumn[3].SetBackgroundColor(playerColor2);
                        dColumn[3].Alpha = 255;
                    }

                }
                else if (dColumn[2].Alpha != canvasColor.Alpha)
                {
                    if (player1Turn == true)
                    {
                        dColumn[2].SetBackgroundColor(playerColor1);
                        dColumn[2].Alpha = 255;
                    }
                    else
                    {
                        dColumn[2].SetBackgroundColor(playerColor2);
                        dColumn[2].Alpha = 255;
                    }

                }
                else if (dColumn[1].Alpha != canvasColor.Alpha)
                {
                    if (player1Turn == true)
                    {
                        dColumn[1].SetBackgroundColor(playerColor1);
                        dColumn[1].Alpha = 255;
                    }
                    else
                    {
                        dColumn[1].SetBackgroundColor(playerColor2);
                        dColumn[1].Alpha = 255;
                    }

                }
                else if (dColumn[0].Alpha != canvasColor.Alpha)
                {
                    if (player1Turn == true)
                    {
                        dColumn[0].SetBackgroundColor(playerColor1);
                        dColumn[0].Alpha = 255;
                    }
                    else
                    {
                        dColumn[0].SetBackgroundColor(playerColor2);
                        dColumn[0].Alpha = 255;
                    }

                }
            
        }

        public void eColumnClick()
        {
            var test = FindViewById<TextView>(Resource.Id.B6);
            var defaultColor = Resources.GetColor(Resource.Color.white);
            var playerColor1 = Resources.GetColor(Resource.Color.player1);
            var playerColor2 = Resources.GetColor(Resource.Color.player2);
            ColorDrawable canvasColor = (ColorDrawable)test.Background;
            int colorId = canvasColor.Color;

                if (eColumn[5].Alpha != canvasColor.Alpha)
                {
                    if (player1Turn == true)
                    {
                        eColumn[5].SetBackgroundColor(playerColor1);
                        eColumn[5].Alpha = 255;
                    }
                    else
                    {
                        eColumn[5].SetBackgroundColor(playerColor2);
                        eColumn[5].Alpha = 255;
                    }
                }
                else if (eColumn[4].Alpha != canvasColor.Alpha)
                {
                    if (player1Turn == true)
                    {
                        eColumn[4].SetBackgroundColor(playerColor1);
                        eColumn[4].Alpha = 255;
                    }
                    else
                    {
                        eColumn[4].SetBackgroundColor(playerColor2);
                        eColumn[4].Alpha = 255;
                    }
                }
                else if (eColumn[3].Alpha != canvasColor.Alpha)
                {
                    if (player1Turn == true)
                    {
                        eColumn[3].SetBackgroundColor(playerColor1);
                        eColumn[3].Alpha = 255;
                    }
                    else
                    {
                        eColumn[3].SetBackgroundColor(playerColor2);
                        eColumn[3].Alpha = 255;
                    }

                }
                else if (eColumn[2].Alpha != canvasColor.Alpha)
                {
                    if (player1Turn == true)
                    {
                        eColumn[2].SetBackgroundColor(playerColor1);
                        eColumn[2].Alpha = 255;
                    }
                    else
                    {
                        eColumn[2].SetBackgroundColor(playerColor2);
                        eColumn[2].Alpha = 255;
                    }

                }
                else if (eColumn[1].Alpha != canvasColor.Alpha)
                {
                    if (player1Turn == true)
                    {
                        eColumn[1].SetBackgroundColor(playerColor1);
                        eColumn[1].Alpha = 255;
                    }
                    else
                    {
                        eColumn[1].SetBackgroundColor(playerColor2);
                        eColumn[1].Alpha = 255;
                    }

                }
                else if (eColumn[0].Alpha != canvasColor.Alpha)
                {
                    if (player1Turn == true)
                    {
                        eColumn[0].SetBackgroundColor(playerColor1);
                        eColumn[0].Alpha = 255;
                    }
                    else
                    {
                        eColumn[0].SetBackgroundColor(playerColor2);
                        eColumn[0].Alpha = 255;
                    }

                }
            
        }

        public void fColumnClick()
        {
            var test = FindViewById<TextView>(Resource.Id.B6);
            var defaultColor = Resources.GetColor(Resource.Color.white);
            var playerColor1 = Resources.GetColor(Resource.Color.player1);
            var playerColor2 = Resources.GetColor(Resource.Color.player2);
            ColorDrawable canvasColor = (ColorDrawable)test.Background;
            int colorId = canvasColor.Color;

                if (fColumn[5].Alpha != canvasColor.Alpha)
                {
                    if (player1Turn == true)
                    {
                        fColumn[5].SetBackgroundColor(playerColor1);
                        fColumn[5].Alpha = 255;
                    }
                    else
                    {
                        fColumn[5].SetBackgroundColor(playerColor2);
                        fColumn[5].Alpha = 255;
                    }
                }
                else if (fColumn[4].Alpha != canvasColor.Alpha)
                {
                    if (player1Turn == true)
                    {
                        fColumn[4].SetBackgroundColor(playerColor1);
                        fColumn[4].Alpha = 255;
                    }
                    else
                    {
                        fColumn[4].SetBackgroundColor(playerColor2);
                        fColumn[4].Alpha = 255;
                    }
                }
                else if (fColumn[3].Alpha != canvasColor.Alpha)
                {
                    if (player1Turn == true)
                    {
                        fColumn[3].SetBackgroundColor(playerColor1);
                        fColumn[3].Alpha = 255;
                    }
                    else
                    {
                        fColumn[3].SetBackgroundColor(playerColor2);
                        fColumn[3].Alpha = 255;
                    }

                }
                else if (fColumn[2].Alpha != canvasColor.Alpha)
                {
                    if (player1Turn == true)
                    {
                        fColumn[2].SetBackgroundColor(playerColor1);
                        fColumn[2].Alpha = 255;
                    }
                    else
                    {
                        fColumn[2].SetBackgroundColor(playerColor2);
                        fColumn[2].Alpha = 255;
                    }

                }
                else if (fColumn[1].Alpha != canvasColor.Alpha)
                {
                    if (player1Turn == true)
                    {
                        fColumn[1].SetBackgroundColor(playerColor1);
                        fColumn[1].Alpha = 255;
                    }
                    else
                    {
                        fColumn[1].SetBackgroundColor(playerColor2);
                        fColumn[1].Alpha = 255;
                    }

                }
                else if (fColumn[0].Alpha != canvasColor.Alpha)
                {
                    if (player1Turn == true)
                    {
                        fColumn[0].SetBackgroundColor(playerColor1);
                        fColumn[0].Alpha = 255;
                    }
                    else
                    {
                        fColumn[0].SetBackgroundColor(playerColor2);
                        fColumn[0].Alpha = 255;
                    }

                }
        }

        public void gColumnClick()
        {
            var test = FindViewById<TextView>(Resource.Id.B6);
            var defaultColor = Resources.GetColor(Resource.Color.white);
            var playerColor1 = Resources.GetColor(Resource.Color.player1);
            var playerColor2 = Resources.GetColor(Resource.Color.player2);
            ColorDrawable canvasColor = (ColorDrawable)test.Background;
            int colorId = canvasColor.Color;

                if (gColumn[5].Alpha != canvasColor.Alpha)
                {
                    if (player1Turn == true)
                    {
                        gColumn[5].SetBackgroundColor(playerColor1);
                        gColumn[5].Alpha = 255;
                    }
                    else
                    {
                        gColumn[5].SetBackgroundColor(playerColor2);
                        gColumn[5].Alpha = 255;
                    }
                }
                else if (gColumn[4].Alpha != canvasColor.Alpha)
                {
                    if (player1Turn == true)
                    {
                        gColumn[4].SetBackgroundColor(playerColor1);
                        gColumn[4].Alpha = 255;
                    }
                    else
                    {
                        gColumn[4].SetBackgroundColor(playerColor2);
                        gColumn[4].Alpha = 255;
                    }
                }
                else if (gColumn[3].Alpha != canvasColor.Alpha)
                {
                    if (player1Turn == true)
                    {
                        gColumn[3].SetBackgroundColor(playerColor1);
                        gColumn[3].Alpha = 255;
                    }
                    else
                    {
                        gColumn[3].SetBackgroundColor(playerColor2);
                        gColumn[3].Alpha = 255;
                    }

                }
                else if (gColumn[2].Alpha != canvasColor.Alpha)
                {
                    if (player1Turn == true)
                    {
                        gColumn[2].SetBackgroundColor(playerColor1);
                        gColumn[2].Alpha = 255;
                    }
                    else
                    {
                        gColumn[2].SetBackgroundColor(playerColor2);
                        gColumn[2].Alpha = 255;
                    }

                }
                else if (gColumn[1].Alpha != canvasColor.Alpha)
                {
                    if (player1Turn == true)
                    {
                        gColumn[1].SetBackgroundColor(playerColor1);
                        gColumn[1].Alpha = 255;
                    }
                    else
                    {
                        gColumn[1].SetBackgroundColor(playerColor2);
                        gColumn[1].Alpha = 255;
                    }

                }
                else if (gColumn[0].Alpha != canvasColor.Alpha)
                {
                    if (player1Turn == true)
                    {
                        gColumn[0].SetBackgroundColor(playerColor1);
                        gColumn[0].Alpha = 255;
                    }
                    else
                    {
                        gColumn[0].SetBackgroundColor(playerColor2);
                        gColumn[0].Alpha = 255;
                    }

                }
            
        }
    }

}