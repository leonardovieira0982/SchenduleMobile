using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SchenduleApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {           
            InitializeComponent();
        }             

        void SignInProcedure(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainHomePage());
            //DisplayAlert("Login", "Login Sucess", "Ok");
        }

        void SignUpProcedure(object sender, EventArgs e)
        {   
            Navigation.PushAsync(new Register());
        }

        void ToolbarItem_Activated(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Register());
        }
    }
}