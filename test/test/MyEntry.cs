using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace test
{
    public class MyEntry : Entry
    {

        public static readonly BindableProperty CurvedCornerRadiusProperty =
        BindableProperty.Create(
        nameof(CurvedCornerRadius),
        typeof(double),
        typeof(MyEntry),
        12.0);
        public double CurvedCornerRadius
        {
            get { return (double)GetValue(CurvedCornerRadiusProperty); }
            set { SetValue(CurvedCornerRadiusProperty, value); }
        }


        public static readonly BindableProperty SelectedBackgroundColorProperty =
       BindableProperty.Create("SelectedBackgroundColor", typeof(Color), typeof(MyEntry), Color.Default);

        /// <summary>
        /// Gets or sets the SelectedBackgroundColor.
        /// </summary>
        public Color SelectedBackgroundColor
        {
            get { return (Color)GetValue(SelectedBackgroundColorProperty); }
            set { SetValue(SelectedBackgroundColorProperty, value); }
        }


        public static readonly BindableProperty CurvedBackgroundColorProperty =
            BindableProperty.Create(
                nameof(CurvedBackgroundColor),
                typeof(Color),
                typeof(MyEntry),
                Color.Default);
        public Color CurvedBackgroundColor
        {
            get { return (Color)GetValue(CurvedBackgroundColorProperty); }
            set { SetValue(CurvedBackgroundColorProperty, value); }
        }

    }
}
