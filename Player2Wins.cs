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
    public class Player2Wins
    {
        public static void player2Wins()
        {
            Context context = Application.Context;
            string text = "Player 1 cool";
            ToastLength duration = ToastLength.Short;
            var toast = Toast.MakeText(context, text, duration);
            toast.Show();
        }
    }
}