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

namespace ServiceMe.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class JobsMaster : ContentPage
    {
        public ListView ListView;

        public JobsMaster()
        {
            InitializeComponent();

            BindingContext = new JobsMasterViewModel();
            ListView = MenuItemsListView;
        }

        class JobsMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<JobsMenuItem> MenuItems { get; set; }
            
            public JobsMasterViewModel()
            {
                MenuItems = new ObservableCollection<JobsMenuItem>(new[]
                {
                    new JobsMenuItem { Id = 0, Title = "Page 1" },
                    new JobsMenuItem { Id = 1, Title = "Page 2" },
                    new JobsMenuItem { Id = 2, Title = "Page 3" },
                    new JobsMenuItem { Id = 3, Title = "Page 4" },
                    new JobsMenuItem { Id = 4, Title = "Page 5" },
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