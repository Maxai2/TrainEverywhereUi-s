using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TrainEverywhere
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewsPage : ContentPage
    {
        public ObservableCollection<News> News { get; set; } = new ObservableCollection<News>();

      /*<div class="new-content-block">
    	    <a href="https://www.bodybuilding.com/content/everyday-beast-salmon-burger-and-shoulder-workout.html"><img src="https://www.bodybuilding.com/images/2018/september/everyday-beast-salmon-burger-and-shoulder-workout-header-600x338.jpg" alt="Everyday Beast: Salmon Burger and Shoulder Workout" title="Everyday Beast: Salmon Burger and Shoulder Workout"/></a>
		    <div>
			    <h4><a href="https://www.bodybuilding.com/content/everyday-beast-salmon-burger-and-shoulder-workout.html">Everyday Beast: Salmon Burger and Shoulder Workout</a></h4>
			    <p class="mobiletarget">Be an everyday beast with a complete pre-workout meal that hits your training macros and a killer shoulder workout to build size and mass.<!-- br/><span style="display: inline-block; margin-top: 10px; font-size: small; font-weight: normal;">Last Updated: 2018-09-11 16:35:00.0</span --></p>
		    </div>
        </div>*/

        public NewsPage()
        {
            InitializeComponent();
            BindingContext = this;

            var news1 = new News
            {
                Description = "Be an everyday beast with a complete pre - workout meal that hits your training macros and a killer shoulder workout to build size and mass.",
                Image = "https://www.bodybuilding.com/images/2018/september/everyday-beast-salmon-burger-and-shoulder-workout-header-600x338.jpg",
                Title = "Everyday Beast: Salmon Burger and Shoulder Workout"
            };

            var news2 = new News
            {
                Description = "Want better shoulders? Signature team athletes Tanner Hobbs, Meg Squats, Rodney Razor, and Brian Casad reveal their favorite delt-building workout.",
                Image = "https://www.bodybuilding.com/images/2018/august/4-workouts-that-are-insanely-effective-at-building-shoulders-header-600x338.jpg",
                Title = "4 Workouts That Are Insanely Effective At Building Shoulders"
            };

            News.Add(news1);
            News.Add(news2);

            //WebClient client = new WebClient();

            ////client.UseDefaultCredentials = true;
            //client.Proxy.Credentials = System.Net.CredentialCache.DefaultCredentials;


            //string data = client.DownloadString("https://www.bodybuilding.com/fun/whats-new.html");

            //string tag = "a";
            //string pattern = string.Format(@"\<{0}.*?\>(?<tegData>.+?)\<\/{0}\>", tag.Trim());

            //Regex regex = new Regex(pattern, RegexOptions.ExplicitCapture);
            //MatchCollection matches = regex.Matches(data);

            //foreach (Match matche in matches)
            //{
            //    News.Add(new News
            //    {
            //        Description = matche.Groups["tegData"].Value
            //    });
            //}
        }

        //public static string GetHtmlPageText(string url)
        //{
        //    WebClient client = new WebClient();

        //    using (Stream data = GenerateStreamFromString(client.DownloadString(url)))
        //    {
        //        using (StreamReader reader = new StreamReader(data))
        //        {
        //            return reader.ReadToEnd();
        //        }
        //    }
        //}

        //public static Stream GenerateStreamFromString(string s)
        //{
        //    var stream = new MemoryStream();
        //    var writer = new StreamWriter(stream);
        //    writer.Write(s);
        //    writer.Flush();
        //    stream.Position = 0;
        //    return stream;
        //}

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            //var item = (sender as Frame).BindingContext as Product;
            //this.Navigation.PushModalAsync(new ProductPage(item));
        }
    }
}