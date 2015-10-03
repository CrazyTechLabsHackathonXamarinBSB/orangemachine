using Geolocator.Plugin;
using System;
using System.Collections.Generic;
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
        }
        public async void btCriarBalada_Clicked(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new CreateEventPage());
        }
        public async void btCheckinAvaliarBalada_Clicked(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new CheckinPage());            
        }        
    }
}
