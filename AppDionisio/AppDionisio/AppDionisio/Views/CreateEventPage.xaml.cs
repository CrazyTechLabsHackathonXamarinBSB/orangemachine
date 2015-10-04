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
    public partial class CreateEventPage : ContentPage
    {
        private IMobileServiceTable<Evento> todoTableEvento = App.MobileService.GetTable<Evento>();
        public Evento Evento
        {
            get
            {
                return this.BindingContext as Evento;
            }
            set
            {
                this.BindingContext = value;
            }
        }
        public CreateEventPage()
        {
            InitializeComponent();
            InitializeContext();
        }

        private void InitializeContext()
        {
            this.Evento = new Evento() { IdUsuario = App.UsuarioLogado.Id, DiaDoEvento = DateTime.Now };
        }

        private async void SalvarEventoButton_OnClicked(object sender, EventArgs e)
        {
            if (!this.Validar())
                await this.DisplayAlert("Atenção", "Revise os campos!", "Ok");
            else
            {
                await todoTableEvento.InsertAsync(this.Evento);
                await this.DisplayAlert("Atenção", "Evento criado com sucesso!", "Ok");
                await Navigation.PushAsync(new MainPage());
            }
        }

        private bool Validar()
        {
            var retorno = true;

            if (String.IsNullOrEmpty(this.Evento.Nome))
                retorno = false;
            if (String.IsNullOrEmpty(this.Evento.Descricao))
                retorno = false;
            if (String.IsNullOrEmpty(this.Evento.IdUsuario))
                retorno = false;
            if (String.IsNullOrEmpty(this.Evento.Logradouro))
                retorno = false;
            if (this.Evento.Numero == 0)
                retorno = false;
            if (String.IsNullOrEmpty(this.Evento.Complemento))
                retorno = false;
            if (String.IsNullOrEmpty(this.Evento.CEP))
                retorno = false;
            if (String.IsNullOrEmpty(this.Evento.Bairro))
                retorno = false;
            if (String.IsNullOrEmpty(this.Evento.Cidade))
                retorno = false;
            if (String.IsNullOrEmpty(this.Evento.Estado))
                retorno = false;
            if (String.IsNullOrEmpty(this.Evento.Latitude))
                retorno = false;
            if (String.IsNullOrEmpty(this.Evento.Longitude))
                retorno = false;

            return retorno;
        }

        private async void CancelarEventoButton_OnClickedOnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
    }
}
