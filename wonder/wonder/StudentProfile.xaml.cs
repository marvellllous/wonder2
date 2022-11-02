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
        public StudentProfile()
        {
            InitializeComponent();
        }

        private void StudLogin_Clicked(object sender, EventArgs e)
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
                bool exists = false ;
                using (SqlCommand cmd = new SqlCommand("select count(*) from [User] where UserName = @UserName"))
                {
                    cmd.Parameters.AddWithValue("UserName", UserName.Text);
                    exists = (int)cmd.ExecuteScalar() > 0;
                }
                if (exists)
                    Console.Write("This username has been using by another user.");
                else
                {
                    Console.Write("Thanks for login in");
                }


            }
        }
    }
}