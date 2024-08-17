using saeproyect.views.product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace saeproyect.views.home
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class vhbody : ContentView
    {
        public vhbody()
        {
            InitializeComponent();
        }

        private void btnsesion_Clicked(object sender, EventArgs e)
        {
            string usuario = "admin";
            string pass = "admin";

            string user_ingress = txt1.Text;
            string pass_ingress = txt2.Text;

            if (usuario == user_ingress && pass == pass_ingress)
            {
                Navigation.PushModalAsync(new vpproduct());
            }
        }
    }
}