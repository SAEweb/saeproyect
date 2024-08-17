using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using saeproyect.views.home;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace saeproyect.views.product
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class vpfooter : ContentView
	{
		public vpfooter ()
		{
			InitializeComponent ();
		}

        private async void rlogin_Clicked(object sender, EventArgs e)
        {
			await Navigation.PushModalAsync(new vhprincipal());
        }
    }
}