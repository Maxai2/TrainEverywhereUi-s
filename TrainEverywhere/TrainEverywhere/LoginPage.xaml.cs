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
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            BindingContext = this;
        }

        private void lblForgotPas_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Test", "Forgot password", "Ok");
        }

        private ICommand signUpCom ;
        public ICommand SignUpCom
        {
            get
            {
                if (signUpCom is null)
                {
                    signUpCom = new Command(
                        execute: () =>
                        {
                            this.Navigation.PushModalAsync(new RegistrationPage());
                        },
                        canExecute: () =>
                        {
                            return true;
                        }
                    );
                }

                return signUpCom;
            }
        }
    }
}
