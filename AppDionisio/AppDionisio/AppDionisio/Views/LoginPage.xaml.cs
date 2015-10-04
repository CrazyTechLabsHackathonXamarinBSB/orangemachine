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
            LimparCampos();
        }
        
        private async void LoginButton_OnClicked(object sender, EventArgs e)
        {
            if (LoginEntry.Text == "" || SenhaEntry.Text == "")
                await this.DisplayAlert("Atenção", "Campos obirgatórios não preenchidos", "Ok");
            else
                await Navigation.PushAsync(new MainPage());
        }

        private async void RegistrarButton_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RegisterUserPage());
        }

        private async void LimparCampos()
        {
            LoginEntry.Text = string.Empty;
            SenhaEntry.Text = string.Empty;
            LoginEntry.Focus();
        }
    }
}
