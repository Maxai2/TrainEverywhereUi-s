﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TrainEverywhere
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MyProgramPage : ContentPage
	{
		public MyProgramPage ()
		{
			InitializeComponent ();

            this.BindingContext = new SlideControlVM();
        }
    }
}