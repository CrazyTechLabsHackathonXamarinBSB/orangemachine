using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace AppDionisio.Views
{
    public partial class RegisterUserPage : ContentPage
    {
        public RegisterUserPage()
        {
            InitializeComponent();
            LimparCampos();
        }

        private async void SalvarButton_OnClicked(object sender, EventArgs e)
        {
            var retorno = true;

            if (String.IsNullOrEmpty(TxtLoginEntry.Text))
                retorno = false;
            if (String.IsNullOrEmpty(TxtNomEntry.Text))
                retorno = false;
            if (String.IsNullOrEmpty(TxtSenhaEntry.Text))
                retorno = false;
            if (String.IsNullOrEmpty(TxtConfirmeSenhaEntry.Text))
                retorno = false;
           if (!TxtSenhaEntry.Text.Equals(TxtConfirmeSenhaEntry.Text))
                retorno = false;

            if (!retorno)
                await this.DisplayAlert("Atenção", "Revise os campos!", "Ok");
            else
                await Navigation.PushAsync(new MainPage());
        }

        private async void CancelarButton_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LoginPage());
        }

        private async void LimparCampos()
        {
            TxtLoginEntry.Text = string.Empty;
            TxtNomEntry.Text = string.Empty;
            TxtSenhaEntry.Text = string.Empty;
            TxtConfirmeSenhaEntry.Text = string.Empty;
            TxtLoginEntry.Focus();
        }
    }
}
