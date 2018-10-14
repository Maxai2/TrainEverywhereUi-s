using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TrainEverywhere
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPageMaster : ContentPage
    {
        public ListView ListView;


        public MainPageMaster()
        {
            InitializeComponent();

            BindingContext = new MainPageMasterViewModel();
            ListView = MenuItemsListView;

        }

        class MainPageMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<MainPageMenuItem> MenuItems { get; set; }
            public float Raiting { get; set; }
            public User user { get; set; }


            public MainPageMasterViewModel()
            {
                user = App.SelectedUser;
                Raiting = 0;
                
                MenuItems = new ObservableCollection<MainPageMenuItem>(new[]
                {
                    new MainPageMenuItem { Id = 0, Title = "News page", TargetType = typeof(NewsPage)},
                    new MainPageMenuItem { Id = 1, Title = "Exercises", TargetType = typeof(ExercisesWikiPage)},
                    new MainPageMenuItem { Id = 2, Title = "My programs", TargetType = typeof(ProgramSettings)}
                    //new MainPageMenuItem { Id = 3, Title = "Basic", TargetType = typeof(NewsPage)}

                    //new MainPageMenuItem { Id = 1, Title = "My profile", TargetType = typeof(MyProfilePage)},
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

        //private ICommand profileOpenCom;
        //public ICommand ProfileOpenCom
        //{
        //    get
        //    {
        //        return profileOpenCom ?? (profileOpenCom = new Command(
        //            execute: () =>
        //            {
        //                this.Navigation.PushModalAsync(App.tabbedPage);
        //            }));
        //    }
        //}

        private void ProfileOpenCom(object sender, EventArgs e)
        {
            this.Navigation.PushModalAsync(App.tabbedPage);
        }


        private void RaitingOpenCom(object sender, EventArgs e)
        {
            this.Navigation.PushModalAsync(new RaitingPage());
        }

        //private ICommand raitingOpenCom;
        //public ICommand RaitingOpenCom
        //{
        //    get
        //    {
        //        return raitingOpenCom ?? (raitingOpenCom = new Command
        //            (execute: () =>
        //            {
        //                this.Navigation.PushModalAsync(new RaitingPage());
        //            }));
        //    }
        //}

    }
}