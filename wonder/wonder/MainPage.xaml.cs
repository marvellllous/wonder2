using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using SQLite;

namespace wonder
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        
       

       

       
        private void Login_Clicked(object sender, EventArgs e)
        {
            Checkindetails(); 
           
           // Navigation.PushAsync(new StudentProfile());
        }

        private void AdminLogin_Clicked(object sender, EventArgs e)
        {
            //Navigation.PushAsync(new AdminProfile());

        }
        async public void Checkindetails()
        {
            List<Person> users = await App.Database.GetPeopleAsync();
        }

        private void RegisterPage_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Registrationprofile());

        }
    }
}
