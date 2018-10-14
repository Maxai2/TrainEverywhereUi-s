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
	public partial class RaitingPage : ContentPage
	{
        private ObservableCollection<Program> programList;
        public ObservableCollection<Program> ProgramList
        {
            get { return programList; }
            set { programList = value; }
        }

        public RaitingPage ()
		{
			InitializeComponent ();
            BindingContext = this;

            ProgramList = new ObservableCollection<Program>();

            foreach (var item in App.AllPrograms.OrderByDescending(r => r.Raiting))
            {
                if (item.user != App.SelectedUser)
                {
                    ProgramList.Add(item);
                }
            }
        }

        private ICommand addProgCom;
        public ICommand AddProgCom
        {
            get
            {
                return addProgCom ?? (addProgCom = new Command(
                    execute: param =>
                    {
                        App.MyProgram.Add(param as Program);
                        DisplayAlert("Information", "Program added", "Ok");
                    }));
            }
        }

        private ICommand addRaiting;
        public ICommand AddRaiting
        {
            get
            {
                return addRaiting ?? (addRaiting = new Command(
                    execute: param =>
                    {
                        (param as Program).Raiting += 1;
                        ProgramList.Clear();
                        foreach (var item in App.AllPrograms.OrderByDescending(r => r.Raiting))
                        {
                            if (item.user != App.SelectedUser)
                            {
                                ProgramList.Add(item);
                            }
                        }
                    }));
            }
        }
    }
}