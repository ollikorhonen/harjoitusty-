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

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace Kiihdytyspeli
{
    public sealed partial class Car : UserControl
    {
        
        // field variables -- Sisäiset muuttujat
        private int speed;
        private int gearAmount;

        // property variables -- Ominaisuudet
        public double LocationX { get; set; }

        public int Speed { get; set; }
        public string Color { get; set; }
        public string Brand { get; set; }
        public int MaxSpeed { get; set; }
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
        public void Accelerate()
        {
            Speed += 20;
        }

        // Jarrutus
        public void Brake()
        {
            Speed -= 20;
        }

        public Car()
        {
            this.InitializeComponent();
            Width = 50;
            Height = 40;
        }
    }
}
