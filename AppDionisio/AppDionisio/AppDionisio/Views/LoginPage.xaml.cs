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
        
        private async void LoginButton_OnClicked(object sender, EventArgs e)
        {
            if (LoginButton.Text == "" || SenhaEntry.Text == "")
                await this.DisplayAlert("Atenção", "Campos obirgatórios não preenchidos", "Ok");
            else
                await Navigation.PushAsync(new MainPage());
        }

        private void CriarContaButton_OnClicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void RegistrarButton_OnClicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
