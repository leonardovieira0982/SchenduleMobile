using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SchenduleApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainHomePageMaster : ContentPage
    {
        public ListView ListView;

        public MainHomePageMaster()
        {
            InitializeComponent();

            BindingContext = new MainHomePageMasterViewModel();
            ListView = MenuItemsListView;
        }

        class MainHomePageMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<MainHomePageMasterMenuItem> MenuItems { get; set; }

            public MainHomePageMasterViewModel()
            {
                MenuItems = new ObservableCollection<MainHomePageMasterMenuItem>(new[]
                {
                    new MainHomePageMasterMenuItem { Id = 0, Title = "Agenda" },
                    //new MainHomePageMasterMenuItem { Id = 1, Title = "Meu Perfil" },
                    //new MainHomePageMasterMenuItem { Id = 2, Title = "Mensagem" },
                    //new MainHomePageMasterMenuItem { Id = 3, Title = "Configurações" },                    
                });
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}