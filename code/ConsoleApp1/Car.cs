using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Car
    {
        public string color;

        public Brand brand;

        public int fuel;
        public int distance;
        public int fuelEfficiency; //L/100km

        public Car() { }
        public Car(string color)
        {
            this.color = color;
        }
        
        public void GoDistance(int distance)
        {
            fuel -= (int)(fuelEfficiency*(distance/100.0));
            this.distance += distance;
        }
        
    }
}
