using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Essentials;
using System.Windows.Input;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace wonder
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Articules : ContentPage
    {
        public ICommand TapCommand => new Command<string>(async (url) => await Launcher.OpenAsync(url));
        public Articules()
        {
            InitializeComponent();
            BindingContext = this;
        }

        private void depression_Clicked(object sender, EventArgs e)
        {

        }

        private void Stress_Clicked(object sender, EventArgs e)
        {

        }

        private void Mentalhealth_Clicked(object sender, EventArgs e)
        {

        }
    }
}