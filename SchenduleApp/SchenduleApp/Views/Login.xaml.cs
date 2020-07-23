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
            NavigationPage.SetHasBackButton(this, true);
            NavigationPage.SetBackButtonTitle(this, "Back");
            InitializeComponent();
        }

        private void ScrollView_Scrolled()
        {

        }

        void SignInProcedure(object sender, EventArgs e)
        {
            DisplayAlert("Login", "Login Sucess", "Ok");
        }

        void SignUpProcedure(object sender, EventArgs e)
        {
            Application.Current.MainPage.Navigation.InsertPageBefore(new Register(), new Login());
            Application.Current.MainPage = new NavigationPage(new Register()); 
        }
    }
}