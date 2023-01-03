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
        public List<Questiongetandset> questiongetandsets { get; private set; }    
        public List<Answer> answers { get; private set; }

        public Questions()
        {
            InitializeComponent();

            // The Questiongetandset are added to the questiongetandsets collecgtion
            questiongetandsets = new List<Questiongetandset>()
            {
                new Questiongetandset() { Number = 1, QName = "Is anything worrying you?" },
                new Questiongetandset() { Number = 2, QName = "Do you usually feel very tired?" },
                new Questiongetandset() { Number = 2, QName = "Is it easy for you to fall asleep?" }
            };



            answers = new List<Answer>()
            {
                new Answer() { Value = 1, Text = "Yes", IsSelected = false },
                new Answer() { Value = 2, Text = "No", IsSelected = false },
                new Answer() { Value = 3, Text = "Sort of", IsSelected = false }

            };
        }
            /*
            questiongetandsets.Add(new Questiongetandset
            {
                QName = "Is anything worrying you?",
                QAnswer = "Yes "
              
            });

            questiongetandsets.Add(new Questiongetandset
            {
                QName = "Do you usually feel very tired?",
                QAnswer = "Yes",
               
            });

            questiongetandsets.Add(new Questiongetandset
            {
                QName = "Is it easy for you to fall asleep?",
                //QAnswer = "Yes"
            });
            /*

            // This is set to the Questions object
            BindingContext = this;

        }

            /*
            if(button.Id.ToString() == "Yes")
            {

            }
            */
        // This should be global 
        public static int score_Y = 0;
        public static int score_N = 0;

       
        private  async void Yes_Clicked(object sender, EventArgs e)
        {
    
            
            Button button = (Button)sender;
            //Console.WriteLine(score_N);
            //var classId = button.ClassId;
            //Console.WriteLine(classId);

            // This gets the ID of any botton that is being clicked so that there is no need to right it again for anoher button 
            switch (button.Text)
            { 
                case "YES":
                    score_Y++;
                    // Console.WriteLine(score_Y);
                    //await DisplayAlert("messege", "hello", "ok");
                    button.IsEnabled = false;
                    await Task.Delay(2000);
                    button.IsEnabled = true;
                    break;
                case "NO":
                    score_N++;
                    Console.WriteLine(score_N);
                    //await DisplayAlert("messege", "bye", "ok");
                    button.IsEnabled = false;
                    await Task.Delay(2000);
                    button.IsEnabled = true;
                    break;
                default :
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