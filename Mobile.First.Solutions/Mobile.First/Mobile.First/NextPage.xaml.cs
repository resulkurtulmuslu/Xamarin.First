﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Mobile.First
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NextPage : ContentPage
    {
        public NextPage()
        {
            InitializeComponent();
        }

        private void btn_Back_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }
    }
}