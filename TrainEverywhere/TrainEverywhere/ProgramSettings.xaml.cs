using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TrainEverywhere
{
    public class prog
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
    }

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProgramSettings : ContentPage
    {
        public ObservableCollection<prog> Mock { get; set; } = new ObservableCollection<prog>();
        public ObservableCollection<string> ProgramNameList { get; set; } = new ObservableCollection<string>();

        public ProgramSettings()
        {
            InitializeComponent();
            BindingContext = this;

            ProgramNameList.Add("Rauf");
            ProgramNameList.Add("Azer");


            Mock.Add(new prog
            {
                Description = "asdadasd",
                Title = "1"
            });
            Mock.Add(new prog
            {
                Description = "asdadasd",
                Title = "2"
            }); Mock.Add(new prog
            {
                Description = "asdadasd",
                Title = "3"
            }); Mock.Add(new prog
            {
                Description = "asdadasd",
                Title = "4"
            });

            Mock.Add(new prog
            {
                Description = "asdadasd",
                Title = "5"
            });
            Mock.Add(new prog
            {
                Description = "asdadasd",
                Title = "6"
            });

        }

        private ICommand exerDeleteCom;
        public ICommand ExerDeleteCom
        {
            get
            {
                if (exerDeleteCom is null)
                {
                    exerDeleteCom = new Command(
                        execute: async param =>
                        {
                            var result = DisplayAlert("Alert", "Do u want to delete this exercise?", "Yes", "No");

                            if (await result)
                                Mock.Remove(param as prog);

                        });
                }

                return exerDeleteCom;
            }
        }

        private ICommand exerEditCom;
        public ICommand ExerEditCom
        {
            get
            {
                return exerEditCom ?? (exerEditCom = new Command(
                    execute: () =>
                    {
                        Navigation.PushModalAsync(new ProgramBuildPage());
                    }));
            }
        }


        private ICommand addNewExer;
        public ICommand AddNewExer
        {
            get
            {
                if (addNewExer is null)
                {
                    addNewExer = new Command(
                        execute: () =>
                        {
                            this.Navigation.PushModalAsync(new NavigationPage(new ProgramBuildPage()));
                        });
                }

                return addNewExer;
            }
        }
    }
}