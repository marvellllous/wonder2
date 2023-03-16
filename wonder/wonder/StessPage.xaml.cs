using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace wonder
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StessPage : ContentPage
    {

        public ICommand TapCommand => new Command<string>(async (url) => await Launcher.OpenAsync(url));
        public StessPage()
        {
            InitializeComponent();
            BindingContext = this; 
        }
    }
}