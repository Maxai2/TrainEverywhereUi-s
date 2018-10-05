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
	public partial class RegistrationPage : ContentPage
	{
		public RegistrationPage ()
		{
			InitializeComponent ();
            BindingContext = this;
		}

        private ICommand registrationNext;
        public ICommand RegistrationNext
        {
            get
            {
                if (registrationNext is null)
                {
                    registrationNext = new Command(
                        execute: () =>
                        {
                            this.Navigation.PushModalAsync(new RegistrationPageNext());
                        },
                        canExecute: () =>
                        {
                            return true;
                        });
                }

                return registrationNext;
            }
        }

    }
}