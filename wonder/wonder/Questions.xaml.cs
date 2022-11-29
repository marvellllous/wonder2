using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace wonder
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Questions : ContentPage
    {
        public IList<Questiongetandset> questiongetandsets { get; private set; }    

        public Questions()
        {
            InitializeComponent();

            // The Questiongetandset are added to the questiongetandsets collecgtion
            questiongetandsets = new List<Questiongetandset>();
            questiongetandsets.Add(new Questiongetandset
            {
                QName = "Is anything worrying you?",
                //QAnswer = "Yes "
              
            });

            questiongetandsets.Add(new Questiongetandset
            {
                QName = "Is it easy for you to fall asleep?",
                //QAnswer = "Yes",
               
            });

            questiongetandsets.Add(new Questiongetandset
            {
                QName = "Is it easy for you to fall asleep?",
                //QAnswer = "Yes"
            });


            // This is set to the Questions object
            BindingContext = this;

        }

            /*
            if(button.Id.ToString() == "Yes")
            {

            }
            */
        

       
        private async void Yes_Clicked(object sender, EventArgs e)
        {
    
            int score_Y = 0;
            int score_N = 0;
            Button button = (Button)sender; 
            // This gets the ID of any botton that is being clicked so that there is no need to right it again for anoher button 
            switch (button.Id.ToString())
            { 
                case "Yes":
                    score_Y = score_Y + 1;
                   // Console.WriteLine(score_Y);
                    await DisplayAlert("messege", "hello", "ok");
                    break;
                case "No":
                    score_N = score_N + 1;
                    Console.WriteLine(score_N);
                    await DisplayAlert("messege", "bye", "ok");
                    break;
                default :
                    break;
         
            } 

            if (score_Y > score_N)
            {
                await this.DisplayAlert("messege", "You are giong to be fine", "Ok");
            }
            else
            {
                await this.DisplayAlert("messege", "You not are giong to be fine", "Ok");
            }
            

        }
    }
}