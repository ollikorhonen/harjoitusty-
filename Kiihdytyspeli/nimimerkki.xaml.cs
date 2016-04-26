using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Kiihdytyspeli
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Nimimerkki : Page
    {
        public string nimimerkki;
        public Nimimerkki()
        {
            this.InitializeComponent();
        }

        private void takaisinbutton_Click(object sender, RoutedEventArgs e)
        {
            Frame rootFrame = Window.Current.Content as Frame;
            if (rootFrame == null) return;
            if (rootFrame.CanGoBack)
            {
                rootFrame.GoBack();
            }
        }

        private void jatkabutton_Click(object sender, RoutedEventArgs e)
        {
            Nimimerkki pelaaja = new Nimimerkki { nimimerkki = nimimerkkitextBox.Text };
            this.Frame.Navigate(typeof(autotalli), pelaaja);

          //  this.Frame.Navigate(typeof(autotalli));
        }
   }
}
