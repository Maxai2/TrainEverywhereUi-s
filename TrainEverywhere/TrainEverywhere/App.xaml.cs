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

        public App()
        {
            InitializeComponent();

            var tabbedPage = new TabbedPage();

            tabbedPage.Children.Add(new ProfilePage());
            tabbedPage.Children.Add(new BodyPage());
            tabbedPage.Children.Add(new PicturesPage());

            MainPage = new ExercisesWikiPage();
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
