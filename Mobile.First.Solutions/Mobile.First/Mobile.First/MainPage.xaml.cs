using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Mobile.First
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            sldr_Value.Value = 0.5;
        }

        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            lbl_Value.Text = string.Format("Değer {0:F2}", e.NewValue);
        }

        async private void btn_Next_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NextPage());
        }
    }
}
