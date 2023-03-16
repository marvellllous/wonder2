using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace wonder
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Articules : ContentPage
    {
       
        public Articules()
        {
            InitializeComponent();
            
        }

        private void depression_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new depressionPage_xaml());
        }

        private void Stress_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new StessPage());
        }

        private void Mentalhealth_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new GeneralmentalPage());
        }
    }
}