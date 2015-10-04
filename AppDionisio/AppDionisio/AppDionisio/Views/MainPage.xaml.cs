using AppDionisio.Models;
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
        public MainPage()
        {
            InitializeComponent();
            var listaEventos = new ObservableCollection<EventosItem>();

            listaEventos.Add(new EventosItem() { Nome = "Balado do José", KM = "0.001 KM" });
            listaEventos.Add(new EventosItem() { Nome = "Balado do XPTO", KM = "0.320 KM" });
            listaEventos.Add(new EventosItem() { Nome = "Balado do TATA", KM = "0.090 KM" });
            listaEventos.Add(new EventosItem() { Nome = "Balado do Morblou", KM = "0.070 KM" });
            listaEventos.Add(new EventosItem() { Nome = "Balado do José", KM = "0.001 KM" });
            listaEventos.Add(new EventosItem() { Nome = "Balado do XPTO", KM = "0.320 KM" });
            listaEventos.Add(new EventosItem() { Nome = "Balado do TATA", KM = "0.090 KM" });
            listaEventos.Add(new EventosItem() { Nome = "Balado do Morblou", KM = "0.070 KM" });
            listaEventos.Add(new EventosItem() { Nome = "Balado do José", KM = "0.001 KM" });
            listaEventos.Add(new EventosItem() { Nome = "Balado do XPTO", KM = "0.320 KM" });
            listaEventos.Add(new EventosItem() { Nome = "Balado do TATA", KM = "0.090 KM" });
            listaEventos.Add(new EventosItem() { Nome = "Balado do Morblou", KM = "0.070 KM" });
            listaEventos.Add(new EventosItem() { Nome = "Balado do José", KM = "0.001 KM" });
            listaEventos.Add(new EventosItem() { Nome = "Balado do XPTO", KM = "0.320 KM" });
            listaEventos.Add(new EventosItem() { Nome = "Balado do TATA", KM = "0.090 KM" });
            listaEventos.Add(new EventosItem() { Nome = "Balado do Morblou", KM = "0.070 KM" });
            listaEventos.Add(new EventosItem() { Nome = "Balado do José", KM = "0.001 KM" });
            listaEventos.Add(new EventosItem() { Nome = "Balado do XPTO", KM = "0.320 KM" });
            listaEventos.Add(new EventosItem() { Nome = "Balado do TATA", KM = "0.090 KM" });
            listaEventos.Add(new EventosItem() { Nome = "Balado do Morblou", KM = "0.070 KM" });
            listaEventos.Add(new EventosItem() { Nome = "Balado do José", KM = "0.001 KM" });
            listaEventos.Add(new EventosItem() { Nome = "Balado do XPTO", KM = "0.320 KM" });
            listaEventos.Add(new EventosItem() { Nome = "Balado do TATA", KM = "0.090 KM" });
            listaEventos.Add(new EventosItem() { Nome = "Balado do Morblou", KM = "0.070 KM" });
            listaEventos.Add(new EventosItem() { Nome = "Balado do José", KM = "0.001 KM" });
            listaEventos.Add(new EventosItem() { Nome = "Balado do XPTO", KM = "0.320 KM" });
            listaEventos.Add(new EventosItem() { Nome = "Balado do TATA", KM = "0.090 KM" });
            listaEventos.Add(new EventosItem() { Nome = "Balado do Morblou", KM = "0.070 KM" });
            listaEventos.Add(new EventosItem() { Nome = "Balado do José", KM = "0.001 KM" });
            listaEventos.Add(new EventosItem() { Nome = "Balado do XPTO", KM = "0.320 KM" });
            listaEventos.Add(new EventosItem() { Nome = "Balado do TATA", KM = "0.090 KM" });
            listaEventos.Add(new EventosItem() { Nome = "Balado do Morblou", KM = "0.070 KM" });
            listaEventos.Add(new EventosItem() { Nome = "Balado do José", KM = "0.001 KM" });
            listaEventos.Add(new EventosItem() { Nome = "Balado do XPTO", KM = "0.320 KM" });
            listaEventos.Add(new EventosItem() { Nome = "Balado do TATA", KM = "0.090 KM" });
            listaEventos.Add(new EventosItem() { Nome = "Balado do Morblou", KM = "0.070 KM" });
            listaEventos.Add(new EventosItem() { Nome = "Balado do José", KM = "0.001 KM" });
            listaEventos.Add(new EventosItem() { Nome = "Balado do XPTO", KM = "0.320 KM" });
            listaEventos.Add(new EventosItem() { Nome = "Balado do TATA", KM = "0.090 KM" });
            listaEventos.Add(new EventosItem() { Nome = "Balado do Morblou", KM = "0.070 KM" });

            this.list.ItemsSource = listaEventos;
        }

        public async void OnItemSelected(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new CheckinPage());
        }

        private async void CadastrarEventoButton_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CreateEventPage());
        }

        private async void SairEventoButton_OnClickedOnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LoginPage());
        }
    }
}
