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
    public partial class Timetable : ContentPage
    {
        public Timetable()
        {
            InitializeComponent();
        }
        public async void ToMenu_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new Menu()));
        }
    }
}