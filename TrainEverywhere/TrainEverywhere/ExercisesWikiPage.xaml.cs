using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TrainEverywhere
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ExercisesWikiPage : ContentPage
	{
		public ExercisesWikiPage()
		{
			InitializeComponent ();
            BindingContext = this;
        }

        private ICommand chectClick;
        public ICommand ChectClick
        {
            get
            {
                return chectClick ?? (chectClick = new Command(
                    execute: () =>
                    {
                        this.Navigation.PushModalAsync(new WebPage("https://weighttraining.guide"));
                    }));
            }
        }

    }
}