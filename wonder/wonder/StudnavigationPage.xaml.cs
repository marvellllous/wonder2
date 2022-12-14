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
    public partial class StudnavigationPage : ContentPage
    {
        public StudnavigationPage()
        {
            InitializeComponent();
        }

        private void QuestionPage_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Questions());
        }

        private void MoodRating_Clicked(object sender, EventArgs e)
        {

        }
    }
}