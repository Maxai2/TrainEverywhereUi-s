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
	public partial class RegistrationPageNext : ContentPage
	{
		public RegistrationPageNext ()
		{
			InitializeComponent ();
            BindingContext = this;
		}

        private ICommand finishSignUpCom;
        public ICommand FinishSignUpCom
        {
            get
            {
                if (finishSignUpCom is null)
                {
                    finishSignUpCom = new Command(
                        execute: () =>
                        {
                            this.Navigation.PushModalAsync(new MainPage());
                        },
                        canExecute: () =>
                        {
                            return true;
                        });
                }

                return finishSignUpCom;
            }
        }

    }
}