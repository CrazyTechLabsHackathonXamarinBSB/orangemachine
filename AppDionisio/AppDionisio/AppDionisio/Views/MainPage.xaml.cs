using AppDionisio.Models;
using Microsoft.WindowsAzure.MobileServices;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace AppDionisio.Views
{
    public partial class MainPage : ContentPage
    {
        private IMobileServiceTable<Evento> todoTableEvento = App.MobileService.GetTable<Evento>();
        public ObservableCollection<EventosItem> ListaItemEventos
        {
            get
            {
                return this.list.ItemsSource as ObservableCollection<EventosItem>;
            }
            set
            {
                this.list.ItemsSource = value;
            }
        }
        public MainPage()
        {
            InitializeComponent();
            this.ListaItemEventos = new ObservableCollection<EventosItem>();
            this.PopularListaDeEventos();
        }

        public async void OnItemSelected(object sender, ItemTappedEventArgs args)
        {
            await Navigation.PushAsync(new CheckinPage(((EventosItem)args.Item).IdEvento));
        }

        private async void CadastrarEventoButton_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CreateEventPage());
        }

        private async void SairEventoButton_OnClickedOnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LoginPage());
        }
        private async Task PopularListaDeEventos()
        {

            this.list.ItemsSource = null;
            var listaEventos = new ObservableCollection<EventosItem>();
            this.list.ItemsSource = listaEventos;
            //TODO: Filtrar...
            var eventos = await todoTableEvento.ToCollectionAsync();
            if (eventos.Any())
            {
                foreach (var item in eventos)
                {
                    var eventoItem = new EventosItem()
                    {
                        IdEvento = item.Id,
                        Nome = item.Nome,
                        KM = "Calcular ..."
                    };
                    listaEventos.Add(eventoItem);
                }
            }
        }
    }
}
