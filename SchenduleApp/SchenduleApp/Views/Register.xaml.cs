using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SchenduleApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Register : ContentPage
    {
        public Register()
        {                        
            InitializeComponent();
        }

        void SignInProcedure(object sender, EventArgs e)
        {
            DisplayAlert("Login", "Login Sucess", "Ok");
        }
    }
}