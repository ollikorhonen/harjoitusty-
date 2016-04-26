using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Kiihdytyspeli
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private MediaElement mediaElement;
        public MainPage()
        {
            this.InitializeComponent();
            InitAudio();
        }

        // load audio from assets
        private async void InitAudio()
        {
            mediaElement = new MediaElement();
            mediaElement.AutoPlay = true;
            StorageFolder folder =
                await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync("Assets");
            StorageFile file = await
                folder.GetFileAsync("musa.mp3");
            var stream = await file.OpenAsync(FileAccessMode.Read);
            mediaElement.SetSource(stream, file.ContentType);
        }

        private void aloitapelibutton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Nimimerkki));
        }

        private void ennatyksetbutton2_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(ennätykset));
        }

        private void tekijatbutton1_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(tekijät));
        }

      
    }
}
