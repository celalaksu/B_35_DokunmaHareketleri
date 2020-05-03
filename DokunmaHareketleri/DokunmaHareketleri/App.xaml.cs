using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DokunmaHareketleri
{
    public partial class App : Application
    {
        public static double ScreenWidth;
        public static double ScreenHeight;

        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();
            MainPage = new NavigationPage(new SwipePage());
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
