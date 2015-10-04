using AppDionisio.Models;
using Microsoft.WindowsAzure.MobileServices;
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
        private IMobileServiceTable<Usuario> todoTableUsuario = App.MobileService.GetTable<Usuario>();
        public RegisterUserPage()
        {
            InitializeComponent();
            this.Usuario = new Usuario() { Facebook = String.Empty};
        }
        public Usuario Usuario
        {
            get
            {
                return this.BindingContext as Usuario;
            }
            set
            {
                this.BindingContext = value;
            }
        }

        private async void SalvarButton_OnClicked(object sender, EventArgs e)
        {
            var retorno = true;

            if (String.IsNullOrEmpty(this.Usuario.Email))
                retorno = false;
            if (String.IsNullOrEmpty(this.Usuario.Nome))
                retorno = false;
            if (String.IsNullOrEmpty(this.Usuario.Senha))
                retorno = false;
            if (String.IsNullOrEmpty(this.Usuario.ConfirmarSenha))
                retorno = false;
           if (String.IsNullOrEmpty(this.Usuario.Senha) || !this.Usuario.Senha.Equals(this.Usuario.ConfirmarSenha))
                retorno = false;

            if (!retorno)
                await this.DisplayAlert("Atenção", "Revise os campos!", "Ok");
            else
            {
                await todoTableUsuario.InsertAsync(this.Usuario);
                await Navigation.PushAsync(new MainPage());
            }
        }

        private async void CancelarButton_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LoginPage());
        }
    }
}
