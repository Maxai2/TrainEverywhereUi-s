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

        public string SignInEmail { get; set; }
        public string SignInPassword { get; set; }

        private ICommand _signIn;

        public ICommand SignIn
        {
            get
            {
                return _signIn ?? (_signIn = new Command((obj) =>
                {
                    foreach (var item in App.Users)
                    {
                        if (item.Email == SignInEmail && item.Password == SignInPassword)
                        {
                            App.SelectedUser = item;
                            Navigation.PushModalAsync(new MainPage());
                        }
                    }
                },
                    (obj) =>
                    {
                        return (String.IsNullOrWhiteSpace(SignInEmail)
                                &&
                                String.IsNullOrWhiteSpace(SignInPassword));
                    }
                ));

            }
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
