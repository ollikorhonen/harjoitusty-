using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.System;
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
    public sealed partial class peliosuus : Page
    {
        private double GameCanvasWidth;
        private double GameCanvasHeight;
        private Car car1;
        private Car car2;
        private Maali maali1;
        private DispatcherTimer timer2;
        private DispatcherTimer timer;
        
        private bool SpacePressed;

        public peliosuus()
        {
            this.InitializeComponent();
            //key listeners
            Window.Current.CoreWindow.KeyDown += CoreWindow_KeyDown;
          //  Window.Current.CoreWindow.KeyUp += CoreWindow_KeyUp;
       
        //create new car register
        Cars carClass= new Cars();


       // get canvas width and height
       GameCanvasWidth = GameCanvas.Width;
       GameCanvasHeight = GameCanvas.Height;




            // create new car object
            car1 = new Car
            {
                LocationX = 50,
                LocationY = GameCanvasHeight / 2,
                Speed = 1, 
                MaxSpeed = 80
            };

            car2 = new Car
            {
                LocationX = 50,
                LocationY = (GameCanvasHeight / 2) - 45,
                Speed = 1,
                MaxSpeed = 100
            };
            maali1 = new Maali
            {
                LocationX = 600,
                LocationY = (GameCanvasHeight / 2) - 45
            };
            // make car object to move


            // add car to canvas
            GameCanvas.Children.Add(car1);
            GameCanvas.Children.Add(car2);
            GameCanvas.Children.Add(maali1);
            maali1.UpdateLocation();

            // game loop
            //timer = new DispatcherTimer();
            //timer.Tick += Timer_Tick;

            //timer.Start();

            //car2 timer
            timer2 = new DispatcherTimer();
            timer2.Tick += Timer2_Tick;
            //timer2.Interval = new TimeSpan(0, 0, 0, 0, 3000);
            timer2.Start();
            // car1.Move();
            //Update car location
            //car1.UpdateLocation();
        }

        private void Timer2_Tick(object sender, object e)
        {
            //car2.Move();
            timer2.Stop();
            timer = new DispatcherTimer();
            timer.Tick += Timer_Tick;
            timer.Start();
            
        }

        /* private void CoreWindow_KeyUp(Windows.UI.Core.CoreWindow sender, Windows.UI.Core.KeyEventArgs args)
         {
             switch (args.VirtualKey)
             {
                 case VirtualKey.Space:
                     SpacePressed = false;
                     break;
             }
         }*/

        private void CoreWindow_KeyDown(Windows.UI.Core.CoreWindow sender, Windows.UI.Core.KeyEventArgs args)
        {
            switch (args.VirtualKey)
            {
                case VirtualKey.Space:
                    SpacePressed = true;
                    break;
            }
        }

        private void Timer_Tick(object sender, object e)
        {
            if (SpacePressed)
            {
                car1.Move();
               // car1.Accelerate2();
               
                //car1.Accelerate2();
                //car1.Accelerate2();
                
                
            }

                car2.Move();
                // car2.Brake();
                //Update car location
                car1.UpdateLocation();
                car2.UpdateLocation();
        }

        private void playAgainButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(peliosuus));
        }

        private void returnGarageButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(autotalli));
        }
    }
}
