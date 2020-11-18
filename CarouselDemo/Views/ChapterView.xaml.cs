using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace CarouselDemo.Views
{
    public partial class ChapterView : ContentView
    {
        public ChapterView()
        {
            InitializeComponent();
        }

        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();

            var chapter = BindingContext as Models.Chapter;

            PagesCarousel.ItemsSource = chapter.Pages;
        }
    }
}
