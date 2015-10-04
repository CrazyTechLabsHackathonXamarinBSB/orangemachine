using AppDionisio.Models;
using Microsoft.WindowsAzure.MobileServices;
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
        private IMobileServiceTable<Usuario> todoTableUsuario = App.MobileService.GetTable<Usuario>();
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
        public LoginPage()
        {
            InitializeComponent();
            this.Usuario = new Usuario();
        }
        
        private async void LoginButton_OnClicked(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.Usuario.Email) || String.IsNullOrEmpty(this.Usuario.Senha))
                await this.DisplayAlert("Atenção", "Campos obirgatórios não preenchidos", "Ok");
            else
            {
                var users =  await todoTableUsuario.Where(o=> o.Email == this.Usuario.Email && o.Senha == this.Usuario.Senha).ToCollectionAsync();

                if (users.Count() > 0)
                {
                    App.UsuarioLogado = users[0];
                    await Navigation.PushAsync(new MainPage());
                }
                else
                    await this.DisplayAlert("Atenção", "Usuário ou Senha inválidos", "Ok");

            }
        }

        private async void RegistrarButton_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RegisterUserPage());
        }
    }
}
