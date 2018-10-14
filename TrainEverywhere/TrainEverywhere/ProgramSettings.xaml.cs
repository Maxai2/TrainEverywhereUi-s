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
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProgramSettings : ContentPage
    {
        public ObservableCollection<Program> ProgramNameList { get; set; }

        private ObservableCollection<Exercise> exercises =new ObservableCollection<Exercise>();

        public ObservableCollection<Exercise> Exercises
        {
            get { return exercises; }
            set { exercises = value; }
        }

        private int programIndex;

        public int ProgramIndex
        {
            get { return programIndex; }
            set { programIndex = value; }
        }

        private string _weekDayindex;
        public string WeekdayIndex
        {
            get { return _weekDayindex; }
            set
            {
                _weekDayindex = value;
                try
                {
                    Exercises.Clear();
                    foreach (var item in ProgramNameList[programIndex].ExerciseList[_weekDayindex])
                    {
                        Exercises.Add(item);
                    }
                }
                catch
                {
                    Exercises.Clear();
                }
            }
        }

        public ProgramSettings()
        {
            InitializeComponent();
            BindingContext = this;
            
            ProgramNameList = App.MyProgram;
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
                                Exercises.Remove(param as Exercise);

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