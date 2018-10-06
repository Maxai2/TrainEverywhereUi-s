using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace TrainEverywhere
{
    public partial class App : Application
    {
        public static int ScreenWidth;
        public static int ScreenHeight;

        public static TabbedPage tabbedPage = new TabbedPage();

        public static User user { get; set; } = new User();

        public App()
        {
            InitializeComponent();

            user.Arms = 40;
            user.Calves = 50;
            user.Chest = 100;
            user.DayOfBirth = new DateTime(1999, 02, 20);
            user.UserEmail = "user@gmail.com";
            user.UserName = "FirstName";
            user.Gender = "Male";
            user.Height = 180;
            user.UserSurname = "LastName";
            user.UserPassword = "qwerty";
            user.Quads = 50;
            user.Shoulders = 70;
            user.Waist = 40;
            user.Weight = 50;

            tabbedPage.Children.Add(new ProfilePage());
            tabbedPage.Children.Add(new BodyPage());
            tabbedPage.Children.Add(new PicturesPage());

            MainPage = new LoginPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
