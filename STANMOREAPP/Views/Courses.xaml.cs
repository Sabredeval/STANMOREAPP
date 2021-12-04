using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace STANMOREAPP.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Courses : ContentPage
    {
        public Courses()
        {
            InitializeComponent();
        }
        public async void ToMenu_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new Menu()));
        }
        public async void ToEng_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new eng()));
        }
        public async void ToBuss_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new buss()));
        }
        public async void ToAcc_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new acc()));
        }
        public async void ToIt_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new it()));
        }
    }
}