using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using MyApp.Droid;
using test;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Color = Android.Graphics.Color;

[assembly: Xamarin.Forms.ExportRenderer(typeof(MySwitch), typeof(MySwitchRenderer))]
namespace MyApp.Droid
{
#pragma warning disable CS0618 
    public class MySwitchRenderer : SwitchRenderer
    {
        public Color CheckedColor { get; set; }
        public Color UncheckedColor { get; set; }

      

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Switch> e)
        {
            base.OnElementChanged(e);

            if (this.Control != null)
            {

                if (this.Control.Checked)
                {
                    this.Control.ThumbDrawable.SetColorFilter(Color.Red, PorterDuff.Mode.SrcAtop);
                    this.Control.TrackDrawable.SetColorFilter(Color.Silver, PorterDuff.Mode.SrcAtop);
                }
                else
                {
                    this.Control.ThumbDrawable.SetColorFilter(Color.LightGray, PorterDuff.Mode.SrcAtop);
                    this.Control.TrackDrawable.SetColorFilter(Color.Silver, PorterDuff.Mode.SrcAtop);
                }
            }
        }

        private void OnCheckedChange(object sender, CompoundButton.CheckedChangeEventArgs e)
        {
          
            var startTime = DateTime.Now;

            if (this.Control.Checked)
            {
                this.Control.ThumbDrawable.SetColorFilter(Color.Red, PorterDuff.Mode.SrcAtop);
                this.Control.TrackDrawable.SetColorFilter(Color.Silver, PorterDuff.Mode.SrcAtop);
                var lp = (App.Current.MainPage as NavigationPage).CurrentPage as ListViewPage;
            }
            else
            {
                this.Control.ThumbDrawable.SetColorFilter(Color.LightGray, PorterDuff.Mode.SrcAtop);
                this.Control.TrackDrawable.SetColorFilter(Color.Silver, PorterDuff.Mode.SrcAtop);
            }
        }

    }
}
#pragma warning restore CS0618 