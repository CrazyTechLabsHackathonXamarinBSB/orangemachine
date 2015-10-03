using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace AppDionisio.Views
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }
        public async void OnButtonClicked(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new MainPage());
        }
    }
}
