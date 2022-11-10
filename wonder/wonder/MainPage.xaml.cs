using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using SQLite;
using Rg.Plugins.Popup.Services; 

namespace wonder
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
       
        }
        
       

       

       // This takes you to the student login page
        private async void Login_Clicked(object sender, EventArgs e)
        {
            Checkindetails(); 
           
           
            //PopupNavigation.PushAsync(new PopupTaskView());  
            Person newPerson = new Person();

            newPerson.UserName = "marv";
            newPerson.Password = "12345";

            int i = await App.Database.SavePersonAsync(newPerson);
            
            Navigation.PushAsync(new StudentProfile());
        }

        // This tyakes you to the Admin login page 
        private void AdminLogin_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AdminProfile());
            //PopupNavigation.PushAsync(new PopupTaskView());

        }
        async public void Checkindetails()
        {
            //List<Person> users = await App.Database.GetPeopleAsync();
            //foreach(Person user in users ){
               // if(user.Name == )
           // }
        }

        private void RegisterPage_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Registrationprofile());

        }
    }
}
