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
using LicoreraRebajaApp.Droid.Views.Components;
using LicoreraRebajaApp.Views.Components;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(LoginEntry), typeof(LoginEntryRenderer))]
namespace LicoreraRebajaApp.Droid.Views.Components
{
    class LoginEntryRenderer : EntryRenderer
    {
        public LoginEntryRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                GradientDrawable gd = new GradientDrawable();
                gd.SetCornerRadius(15);
                gd.SetStroke(3, global::Android.Graphics.Color.ParseColor("#2c5697"));
                Control.SetBackground(gd);
                Control.SetPadding(10, 5, 10, 5);
                Control.SetTextColor(global::Android.Graphics.Color.ParseColor("#2c5697"));
                Control.SetHintTextColor(global::Android.Graphics.Color.ParseColor("#662c5697"));
            }
        }
    }
}