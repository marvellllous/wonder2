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


        async private void Register_Clicked(object sender, EventArgs e)
        {
            Person newPerson = new Person();

            newPerson.Name = UserName.Text;
            newPerson.Password = Password.Text;

            await App.Database.SavePersonAsync(newPerson);
            await Navigation.PopAsync(); 


        }
    }
}