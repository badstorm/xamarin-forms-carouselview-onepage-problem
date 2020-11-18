using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CarouselDemo
{
    public partial class App : Application
    {
        public static List<Models.Chapter> MainData { get; set; }


        public App()
        {
            InitializeComponent();


            MainData = new List<Models.Chapter>
            {
                new Models.Chapter
                {
                    Title = "Chapter 1",
                    Pages =  new List<Models.Page>
                    {
                        new Models.Page
                        {
                            Title = "Page 1 - 1",
                            BackColor = Color.Red
                        },
                        new Models.Page
                        {
                            Title = "Page 2 - 1",
                            BackColor = Color.GhostWhite
                        },
                        new Models.Page
                        {
                            Title = "Page 3 - 1",
                            BackColor = Color.Gainsboro
                        },
                    }
                },
                new Models.Chapter
                {
                    Title = "Chapter 2",
                    Pages =  new List<Models.Page>
                    {
                        new Models.Page
                        {
                            Title = "Page 1 - 2",
                            BackColor = Color.YellowGreen
                        },
                        new Models.Page
                        {
                            Title = "Page 2 - 2",
                            BackColor = Color.AntiqueWhite
                        },
                        new Models.Page
                        {
                            Title = "Page 3 - 2",
                            BackColor = Color.Aqua
                        },
                    }
                },
                new Models.Chapter
                {
                    Title = "Chapter 3",
                    Pages =  new List<Models.Page>
                    {
                        new Models.Page
                        {
                            Title = "Page 1 - 3",
                            BackColor = Color.Blue
                        },
                        new Models.Page
                        {
                            Title = "Page 2 - 3",
                            BackColor = Color.Brown
                        },
                        new Models.Page
                        {
                            Title = "Page 3 - 3",
                            BackColor = Color.CadetBlue
                        },
                    }
                }
            };

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
