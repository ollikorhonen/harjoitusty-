﻿using System;
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
    public sealed partial class peliosuus : Page
    {
        private double GameCanvasWidth;
        private double GameCanvasHeight;
        private Car car1;

        private DispatcherTimer timer;

        public peliosuus()
        {
            this.InitializeComponent();

        // Ei mitaan hajua miten tama toimii
       
        //create new car register
        Cars carClass= new Cars();


       // get canvas width and height
       GameCanvasWidth = GameCanvas.Width;
       GameCanvasHeight = GameCanvas.Height;




            // create new car object
            Car car1 = new Car
            {
                LocationX = 1,
                LocationY = GameCanvasHeight / 2
            };

            // make car object to move


        // add car to canvas
        GameCanvas.Children.Add(car1);


            // game loop
            timer = new DispatcherTimer();
            timer.Tick += Timer_Tick;
            timer.Interval = new TimeSpan(0, 0, 0, 0, 1000);
            timer.Start();
            

            car1.Move();
            //Update car location
            car1.UpdateLocation();
        }

        private void Timer_Tick(object sender, object e)
        {
            car1.Move();
            //Update car location
            car1.UpdateLocation();
        }
    }
}
