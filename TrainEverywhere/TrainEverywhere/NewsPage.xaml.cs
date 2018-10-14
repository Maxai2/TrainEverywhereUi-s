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
                Description = "Today's episode is a back and hamstring workout followed by a very special post-workout meal: delicious ribeye with low-carb, keto-friendly sides.",
                Image = "https://www.bodybuilding.com/images/2018/october/everyday-besat-back-and-hamstring-workout-with-keto-ribeye-header-600x338.jpg",
                Title = "Back and Hamstring Workout With Keto Ribeye"
            };

            var news2 = new News
            {
                Description = "The hardest part of a bench press is raising the bar off your chest. Good leg drive helps you move the bar until your strong pressing muscles can take over. Put together a leg drive bench press and prepare to break some old PRs.",
                Image = "https://www.bodybuilding.com/images/2018/october/is-leg-drive-important-for-a-good-bench-press-header-600x338.jpg",
                Title = "Ask The Super Strong Guy: Is Leg Drive Important For A Good Bench Press?"
            };

            var news3 = new News
            {
                Description = "On the eve of her biggest comp of the year, the YouTube star and devotee of the heavy lifting life talks with us about prep, protein bars, and how good it feels to buckle down and say no to distraction.",
                Image = "https://www.bodybuilding.com/images/2018/september/meg-squats-steps-up-to-the-platform-header-600x338.jpg",
                Title = "Meg Squats Steps Up To The Platform"
            };

            var news4 = new News
            {
                Description = "Meet the most important aminos not currently on your radar! These are the siblings of branched-chain amino acids who don't make the headlines, but should definitely make their way into your supplement arsenal.",
                Image = "https://www.bodybuilding.com/images/2018/october/what-lifters-need-to-know-about-essential-amino-acids-header-600x338.jpg",
                Title = "What Lifters Need To Know About Essential Amino Acids"
            };

            var news5 = new News
            {
                Description = "\"Dietary protein\" just means the protein you get from eating whole foods like beef, fish, soy, legumes, and nuts. Find out why getting most of your protein from food is a smart way to go.",
                Image = "https://www.bodybuilding.com/images/2018/september/benefits-of-dietary-protein-header-600x338.jpg",
                Title = "What Are The Benefits Of Dietary Protein?"
            };

            News.Add(news1);
            News.Add(news2);
            News.Add(news3);
            News.Add(news4);
            //News.Add(news5);

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