using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite; 
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace wonder
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StudentProfile : ContentPage
    {
        public  StudentProfile()
        {
            InitializeComponent();
        }

        private async void  StudLogin_Clicked(object sender, EventArgs e)
        {
            if (UserName.Text == "")
            {
                 Console.Write("Enter A Username");
            }
            else if (Password.Text == "")
            {
                Console.Write("Enter A Valid Password");
            }
            else
            {
                
                List<Person> p = await App.Database.GetPeopleAsync(UserName.Text);
                if (p.Count > 0 )
                     await this.DisplayAlert( "messege",  "Usernasme taken", "ok");

                else
                {
                    await this.DisplayAlert("messege", "Thanks for login in", "ok");
                }


            }
        }
    }
}