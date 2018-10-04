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
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PicturesPage : ContentPage
	{
        public ObservableCollection<string> BodyPic { get; set; }

        public PicturesPage ()
		{
			InitializeComponent ();
            BindingContext = this;

            BodyPic = new ObservableCollection<string>
            {
                "https://www.bodybuilding.com/images/2018/september/everyday-beast-salmon-burger-and-shoulder-workout-header-600x338.jpg",
                "https://www.bodybuilding.com/images/2018/september/everyday-beast-salmon-burger-and-shoulder-workout-header-600x338.jpg",
                "https://www.bodybuilding.com/images/2018/september/everyday-beast-salmon-burger-and-shoulder-workout-header-600x338.jpg",
                "https://www.bodybuilding.com/images/2018/september/everyday-beast-salmon-burger-and-shoulder-workout-header-600x338.jpg",
                "https://www.bodybuilding.com/images/2018/september/everyday-beast-salmon-burger-and-shoulder-workout-header-600x338.jpg",
                "https://www.bodybuilding.com/images/2018/september/everyday-beast-salmon-burger-and-shoulder-workout-header-600x338.jpg"
            };
        }
	}
}