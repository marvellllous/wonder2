using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
using Xamarin.Forms.Xaml;

namespace wonder
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Moodrating : ContentPage
    {

        public static int value_one_to_three = 0;
        public static int value_four_to_five = 0;
        public static int value_six_to_eight= 0;
        public static int value_nine_to_ten = 0;
       
        public Moodrating()
        {
            InitializeComponent();
           
        }

        private async void  one_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            RadioButton numb_button = (RadioButton)sender;
            //Console.WriteLine(score_N);
            Console.WriteLine(numb_button.Id.ToString());
            var IDNUMBEROfButton = (sender as RadioButton).StyleId;

            switch (IDNUMBEROfButton)
            {
                case "one":
                    value_one_to_three++;
                    numb_button.IsEnabled = false;
                    await Task.Delay(2000);
                    numb_button.IsEnabled = true;
                    break;
                // This can't work because the function as the attribute await 
                //DisplayAlert("messege", "Thanks for rating today come back tommorow", "Ok");
                case "two":
                    value_one_to_three++;
                    numb_button.IsEnabled = false;
                    await Task.Delay(2000);
                    numb_button.IsEnabled = true;
                    break;
                case "three":
                    value_one_to_three++;
                    numb_button.IsEnabled = false;
                    await Task.Delay(2000);
                    numb_button.IsEnabled = true;
                    break;
                case "four":
                    value_four_to_five++;
                    numb_button.IsEnabled = false;
                    await Task.Delay(2000);
                    numb_button.IsEnabled = true;
                    break;
                case "five":
                    value_four_to_five++;
                    numb_button.IsEnabled = false;
                    await Task.Delay(2000);
                    numb_button.IsEnabled = true;
                    break;
                case "six":
                    value_six_to_eight++;
                    numb_button.IsEnabled = false;
                    await Task.Delay(2000);
                    numb_button.IsEnabled = true;
                    break;
                case "seven":
                    value_six_to_eight++;
                    numb_button.IsEnabled = false;
                    await Task.Delay(2000);
                    numb_button.IsEnabled = true;
                    break;
                case "eight":
                    value_six_to_eight++;
                    numb_button.IsEnabled = false;
                    await Task.Delay(2000);
                    numb_button.IsEnabled = true;
                    break;
                case "nine":
                    value_nine_to_ten++;
                    numb_button.IsEnabled = false;
                    await Task.Delay(2000);
                    numb_button.IsEnabled = true;
                    break;
                case "ten":
                    value_nine_to_ten++;
                    numb_button.IsEnabled = false;
                    await Task.Delay(2000);
                    numb_button.IsEnabled = true;
                    break;
            }

        }

        private void numb_Submit_Clicked(object sender, EventArgs e)
        {
            if (value_one_to_three > value_four_to_five)
            {
                DisplayAlert("messege", "Talk to someone", "Ok");
            }
            if (value_six_to_eight > value_nine_to_ten)
            {
                DisplayAlert("messege", "You should read some articules on how to cope with mental heatlh or talk to someone", "Ok");
                Navigation.PushAsync(new Articules());
            }
            if (value_nine_to_ten > value_one_to_three)
            {
                DisplayAlert("messege", "Even if your rating is high still try to talk to someone about you mental health", "Ok");
            }
            
        }
    }
}