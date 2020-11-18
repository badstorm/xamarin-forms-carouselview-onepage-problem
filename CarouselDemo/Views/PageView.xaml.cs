using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace CarouselDemo.Views
{
    public partial class PageView : ContentView
    {
        public PageView()
        {
            InitializeComponent();
        }

        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();

            var page = BindingContext as Models.Page;

            BackgroundColor = page.BackColor;
        }
    }
}
