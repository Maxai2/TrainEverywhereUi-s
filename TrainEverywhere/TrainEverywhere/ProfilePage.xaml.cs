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
	public partial class ProfilePage : ContentPage
	{
        public User SelectedUser { get; set; }

        public ProfilePage()
        {
            InitializeComponent();
            SelectedUser = App.SelectedUser;
            BindingContext = this;
        }
    }
}