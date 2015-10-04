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
        private readonly ObservableCollection<EventosItem> _listaItemEventos = new ObservableCollection<EventosItem>();

        public ObservableCollection<EventosItem> ListaItemEventos
        {
            get
            {
                return _listaItemEventos;
            }
        }
        public MainPage()
        {
            InitializeComponent();
            BindingContext = this;
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
            ListaItemEventos.Clear();
            //TODO: Filtrar...
            var eventos = await todoTableEvento.ToCollectionAsync();
            if (eventos.Any())
            {
                //var Coordinates = new Coordinates();
                //var localizacaoAtual = await Coordinates.GetGeolocator();
                foreach (var item in eventos)
                {
                    //var latEvento = Convert.ToDouble(item.Latitude);
                    //var longEvento = Convert.ToDouble(item.Longitude);
                    var eventoItem = new EventosItem()
                    {
                        IdEvento = item.Id,
                        Nome = item.Nome,
                        KM =  "1500 km"//Coordinates.Distance(localizacaoAtual.Latitude, localizacaoAtual.Longitude, latEvento, longEvento).ToString() + " KM"
                    };
                    ListaItemEventos.Add(eventoItem);
                }
            }
            this.list.ItemsSource = null;
            this.list.ItemsSource = ListaItemEventos;
        }
    }
}
