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
    public class prog
    {
        public string Title { get; set; }
        public string Description { get; set; }
    }

	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ProgramSettings : ContentPage
	{
        public ObservableCollection<prog> Mock { get; set; }

        public ProgramSettings ()
		{
			InitializeComponent ();
            BindingContext = this;

            Mock = new ObservableCollection<prog>()
            {
                new prog()
                {
                    Description = "qwery",
                    Title = "qwertt"
                },
                new prog()
                {
                    Description = "asdf",
                    Title = "xvbxcbxv"
                }
            };
		}
	}
}