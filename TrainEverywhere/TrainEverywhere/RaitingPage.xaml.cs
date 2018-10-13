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
	public partial class RaitingPage : ContentPage
	{
        public ObservableCollection<string> RaitingList { get; set; } = new ObservableCollection<string>();

        public RaitingPage ()
		{
			InitializeComponent ();
            BindingContext = this;

            RaitingList.Add("qwerty1");
            RaitingList.Add("qwerty2");
            RaitingList.Add("qwerty3");
            RaitingList.Add("qwerty4");

        }
	}
}