using System;
using System.Collections.Generic;
using System.Diagnostics;
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

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace Kiihdytyspeli
{
    public sealed partial class Car : UserControl
    {
        
        // field variables -- Sisäiset muuttujat
        private double speed;
        public double Accelerate = 0.5;
        public double MaxSpeed = 1000.0;
        private int gearAmount;
        private double locationX;
        private double maxLocationX = 1150;

        // property variables -- Ominaisuudet
        public double LocationX
        {
            get
            {
                return locationX;
            }
            set
            {
                if (value <= maxLocationX) locationX = value;
                else
                {
                    locationX = maxLocationX;
                }
            }
        }
        public double LocationY { get; set; }
        public int Speed { get; set; }
        public string Color { get; set; }
        public string Brand { get; set; }
        // public int MaxSpeed { get; set; }
        public int CurrentGear { get; set; }
        public int GearAmount { get; set; }
        public int CarPrice { get; set; }
        

        // methods -- Toiminnallisuudet

        // Suurempi vaihde
        public void GearShiftUp()
        {
            CurrentGear += 1;
        }

        // Pienempi vaihde
        public void GearShiftDown()
        {
            CurrentGear -= 1;
        }

        // Kiihdytys
        public void Accelerate2()
        {
            MaxSpeed += 100;
        }

        // Jarrutus
        public void Brake()
        {
            MaxSpeed = 0;
        }

        public Car()
        {
            this.InitializeComponent();
            Width = 50;
            Height = 40;
        }
        public void UpdateLocation()
        {
            SetValue(Canvas.LeftProperty, LocationX);
            SetValue(Canvas.TopProperty, LocationY);
        }

        public void Move()
        {
            speed += Accelerate;

            if (speed > MaxSpeed) speed = MaxSpeed;
            SetValue(Canvas.LeftProperty, LocationX);
           // Debug.WriteLine(speed);
            // update location values
            LocationX += 1 * speed;
        }





    }
}
