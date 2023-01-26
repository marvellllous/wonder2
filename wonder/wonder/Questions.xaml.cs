using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace wonder
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Questions : ContentPage
    {
        public static int score_Y = 0;
        public static int score_N = 0;
        public List<Questiongetandset> questionsToAsk { get; set; }
        
        public List<Questiongetandset> Modal { get; private set; }

        public Questions()
        {
            InitializeComponent();
         

            questionsToAsk = new List<Questiongetandset>()
            {
                new Questiongetandset() { Number = 1, QName = "Is anything worrying you?" },
                new Questiongetandset() { Number = 2, QName = "Do you usually feel very tired?" },
                new Questiongetandset() { Number = 3, QName = "Is it easy for you to fall asleep?" },
            };

           
            this.BindingContext = questionsToAsk;
        }

        private void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }

        private async void RadioButton_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
           RadioButton button = (RadioButton)sender;
            //Console.WriteLine(score_N);
            Console.WriteLine(button.Id.ToString());
            var IDOfButton = (sender as RadioButton).StyleId;

            // This gets the ID of any botton that is being clicked so that there is no need to right it again for anoher button 
            switch (IDOfButton)
            {
                case "Yes":
                    score_Y++;
                    //await DisplayAlert("messege", "hello", "ok");
                    button.IsEnabled = false;
                    await Task.Delay(2000);
                    button.IsEnabled = true;
                    break;
                case "No":
                    score_N++;
                    Console.WriteLine(score_N);
                    //await DisplayAlert("messege", "bye", "ok");
                    button.IsEnabled = false;
                    await Task.Delay(2000);
                    button.IsEnabled = true;
                    break;
                default:
                    break;

            }
        }
        
        private void Submit_Clicked(object sender, EventArgs e)
        {
            if (score_Y > score_N)
            {
                DisplayAlert("messege", "You are giong to be fine", "Ok");
            }
            if (score_N > score_Y)
            {
                DisplayAlert("messege", "You are not giong to be fine", "Ok");
            }

        }
    }

}