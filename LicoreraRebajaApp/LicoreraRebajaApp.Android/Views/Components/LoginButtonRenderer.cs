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

[assembly: ExportRenderer(typeof(LoginButton), typeof(LoginButtonRenderer))]
namespace LicoreraRebajaApp.Droid.Views.Components
{
    class LoginButtonRenderer : ButtonRenderer
    {
        public LoginButtonRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Button> e)
        {
            base.OnElementChanged(e);

            GradientDrawable gradientDrawable = new GradientDrawable();
            Control.SetHintTextColor(global::Android.Graphics.Color.Rgb(182, 182, 182));

            gradientDrawable.SetShape(ShapeType.Rectangle);
            gradientDrawable.SetColor(global::Android.Graphics.Color.ParseColor("#2c5697"));
            gradientDrawable.SetStroke(3, global::Android.Graphics.Color.ParseColor("#2c5697"));
            gradientDrawable.SetCornerRadius(15);
            
            Control.SetBackground(gradientDrawable);
        }
    }
}