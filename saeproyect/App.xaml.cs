using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using saeproyect.views.home;
using saeproyect.views.product;

namespace saeproyect
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new vhprincipal();
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
