using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiihdytyspeli
{
    class Cars: Car
    {
        // field variables
        private List<Car> cars;

        // property variables
        public string Owner { get; set; }
        public Cars()
        {
            cars = new List<Car>();
        }

        public void AddCar(Car car)
        {
            cars.Add(car);
        }

        public void PrintData()
        {
            foreach (Car car in cars)
            {
                car.ToString();
            }
        }

    }
}
