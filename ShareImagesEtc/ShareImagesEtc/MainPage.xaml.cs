using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Essentials;

namespace ShareImagesEtc
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Share.RequestAsync(new ShareTextRequest
            {
                Subject = "Caleb's YouTube",
                Text = "Please subscribe",
                Title = "Scave",
                Uri = "Git.Scave222.com"
            });
        }

        private async void Button_ClickedOthers(object sender, EventArgs e)
        {
            var image = await MediaPicker.PickPhotoAsync();
            if (image == null)
                return;
            await Share.RequestAsync(new ShareFileRequest
            {
                Title = "Scave",
                File = new ShareFile(image)
            });
        }
    }
}
