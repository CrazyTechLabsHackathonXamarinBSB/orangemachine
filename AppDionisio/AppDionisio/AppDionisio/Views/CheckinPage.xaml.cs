using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace AppDionisio.Views
{
    public partial class CheckinPage : ContentPage
    {
        public CheckinPage()
        {
            InitializeComponent();
            //LimparCampos();
        }

        private async void CheckinButton_OnClicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private async void LikeButton_OnClicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private async void NoLike_OnClicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private async void Cancelar_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }

        private void LimparCampos()
        {
            LblBairro.Text = String.Empty;
            LblCidade.Text = String.Empty;
            LblEstado.Text = String.Empty;
            LblLogradouro.Text = String.Empty;
            LblNome.Text = String.Empty;
            LblNomeCriadoEvento.Text = String.Empty;
            LblQtdCheckins.Text = String.Empty;
            LblQtdDesLikes.Text = String.Empty;
            LblQtdLikes.Text = String.Empty;
        }
    }
}
