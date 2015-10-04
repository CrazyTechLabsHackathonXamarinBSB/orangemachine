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
        public CreateEventPage()
        {
            InitializeComponent();
        }

        private async void SalvarEventoButton_OnClickedo_OnClicked(object sender, EventArgs e)
        {
            //if (LoginEntry.Text == "" || SenhaEntry.Text == "")
            //    await this.DisplayAlert("Atenção", "Campos obirgatórios não preenchidos", "Ok");
            //else
            await Navigation.PushAsync(new MainPage());
        }

        private async void CancelarEventoButton_OnClickedOnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
    }
}
