using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiihdytyspeli
{
    class Car
    {
        // field variables -- Sisäiset muuttujat
        private int speed;
        private int gearAmount;

        // property variables -- Ominaisuudet
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

        public override string ToString()
        {
            return Speed + " " + Color + Brand + " " + MaxSpeed + CurrentGear + " " + GearAmount + "" + CarPrice;
        }
    }
}
