using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TrainEverywhere
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ProgramBuildPage : ContentPage
	{
        public ObservableCollection<string> shedule { get; set; } = new ObservableCollection<string>();

		public ProgramBuildPage ()
		{
			InitializeComponent ();
            BindingContext = this;

            shedule.Add("qwerty");
            shedule.Add("qwerty");
            shedule.Add("qwerty");
        }
	}
}