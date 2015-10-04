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
    public partial class CheckinPage : ContentPage
    {
        private IMobileServiceTable<Detalhe> todoTableDetalhe = App.MobileService.GetTable<Detalhe>();
        private IMobileServiceTable<Evento> todoTableEvento = App.MobileService.GetTable<Evento>();
        private IMobileServiceTable<Usuario_Evento> todoTableUsuario_Evento = App.MobileService.GetTable<Usuario_Evento>();
        public CheckinPage()
        {
            InitializeComponent();
        }

        public CheckinPage(string IdEvento)
            : this()
        {
            this.BuscarDetalheEvento(IdEvento);
        }

        public Detalhe Detalhe
        {
            get
            {
                return this.BindingContext as Detalhe;
            }
            set
            {
                this.BindingContext = value;
            }
        }

        private async void CheckinButton_OnClicked(object sender, EventArgs e)
        {
            var chekiin = await this.UsuarioJaDeuChekin();
            if (chekiin)
            {
                await this.DisplayAlert("Atenção", "Usuário já deu Check-in!", "Ok");
            }
            else
                this.DarCheckIn();
        }

        private async void LikeButton_OnClicked(object sender, EventArgs e)
        {
            var chekiin = await this.UsuarioJaDeuChekin();
            if (!chekiin)
            {
                await this.DisplayAlert("Atenção", "Usuário ainda não deu Check-in!", "Ok");
            }
            else
                this.AvaliarEvento(StatatusEnum.Like);
        }

        private async void NoLike_OnClicked(object sender, EventArgs e)
        {
            var chekiin = await this.UsuarioJaDeuChekin();
            if (!chekiin)
            {
                await this.DisplayAlert("Atenção", "Usuário ainda não deu Check-in!", "Ok");
            }
            else
                this.AvaliarEvento(StatatusEnum.Deslike);
        }

        private async void Cancelar_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }

        private async Task BuscarDetalheEvento(string IdEvento)
        {
            var detalheItem = await todoTableDetalhe.Where(o => o.IdEvento == IdEvento).ToCollectionAsync();

            if (detalheItem.Any())
            {
                var eventoItem = await todoTableEvento.Where(o => o.Id == IdEvento).ToCollectionAsync();
                if (eventoItem.Any())
                {
                    detalheItem[0].Evento = eventoItem[0];
                    detalheItem[0].Nome = detalheItem[0].Evento.Nome;
                    detalheItem[0].Local = String.Format("{0} - {1}/{2}", detalheItem[0].Evento.Nome, detalheItem[0].Evento.Cidade, detalheItem[0].Evento.Estado);
                }

                this.Detalhe = detalheItem[0];
            }
            else
            {
                this.InitializeContext(IdEvento);
                await todoTableDetalhe.InsertAsync(this.Detalhe);
            }
        }

        private async void InitializeContext(string IdEvento)
        {
            this.Detalhe = new Detalhe()
            {
                Evento = new Evento(),
                IdEvento = IdEvento,
                Checkins = 0,
                Likes = 0,
                Deslike = 0
            };

            var eventoItem = await todoTableEvento.Where(o => o.Id == IdEvento).ToCollectionAsync();
            if (eventoItem.Any())
            {
                this.Detalhe.Evento = eventoItem[0];
                this.Detalhe.Nome = this.Detalhe.Evento.Nome;
                this.Detalhe.Local = String.Format("{0} - {1}/{2}", this.Detalhe.Evento.Nome, this.Detalhe.Evento.Cidade, this.Detalhe.Evento.Estado);
            }
        }

        private async Task<bool> UsuarioJaDeuChekin()
        {
            bool checkin = false;
            var eventosUsuarios = await todoTableUsuario_Evento.Where(o => o.IdUsuario == App.UsuarioLogado.Id).ToCollectionAsync();
            if (eventosUsuarios.Any())
                checkin = true;

            return checkin;
        }

        private async void AvaliarEvento(StatatusEnum status)
        {
            var usuarioEventoFind = await todoTableUsuario_Evento.Where(o => o.IdUsuario == App.UsuarioLogado.Id && o.IdEvento == this.Detalhe.IdEvento).ToCollectionAsync();
            var usuarioEvento = usuarioEventoFind[0];

            switch (usuarioEvento.StatusEnum)
            {
                case StatatusEnum.Defaut: // Dá uma nota
                    if (status == StatatusEnum.Deslike)
                        this.Detalhe.Deslike++;
                    if (status == StatatusEnum.Like)
                        this.Detalhe.Likes++;
                    break;
                case StatatusEnum.Like: // Muda a avaliação de like para deslike
                    if (status == StatatusEnum.Deslike)
                    {
                        this.Detalhe.Likes--;
                        this.Detalhe.Deslike++;
                    }
                    break;
                case StatatusEnum.Deslike:// Muda a avaliação de Deslike para Like
                    if (status == StatatusEnum.Like)
                    {
                        this.Detalhe.Deslike--;
                        this.Detalhe.Likes++;
                    }
                    break;
            }
            await todoTableDetalhe.UpdateAsync(this.Detalhe);
        }

        private async void DarCheckIn()
        {
            this.Detalhe.Checkins++;
            await todoTableDetalhe.UpdateAsync(this.Detalhe);

            var eventoUsuario = new Usuario_Evento() { IdEvento = this.Detalhe.IdEvento, IdUsuario = App.UsuarioLogado.Id };
            await todoTableUsuario_Evento.InsertAsync(eventoUsuario);
        }
    }
}
