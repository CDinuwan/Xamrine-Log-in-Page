using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextApp.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TextApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }
        void SignInProcedure(object sender,EventArgs e)
        {
            User user = new User(txtUsername.Text, txtPassword.Text);
            if (user.CheckInformation())
            {
                DisplayAlert("login", "Login Suceess", "Oke");
            }
            else
            {
                DisplayAlert("login", "Login not correct,empty username or password", "Oke");
            }
        }
    }
}