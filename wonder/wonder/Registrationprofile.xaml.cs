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
    public partial class Registrationprofile : ContentPage
    {
        public Registrationprofile()
        {
            InitializeComponent();
        }

        public async Task<bool> IsUsernameTakenAsync(string username)
        {
            bool exists = await App.Database.CheckUsernameAsync(username);
            return exists;
        }

        async private void Register_Clicked(object sender, EventArgs e)
        {

            Person newPerson = new Person();

            newPerson.UserName = UserName.Text;
            newPerson.Password = Password.Text;

           
            if ( await IsUsernameTakenAsync(UserName.Text))
            {
                await this.DisplayAlert( "messege",  "Usernasme taken", "ok");
            }
            else
            {
                await this.DisplayAlert("messege", "Thanks for registering ", "ok");
                await App.Database.SavePersonAsync(newPerson);
                await Navigation.PopAsync();
            }

        }
    }
}