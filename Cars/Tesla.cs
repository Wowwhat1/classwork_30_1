using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    internal class Tesla : ICar, IElectricCar
    {
        public string Model { get; private set; }
        public string Color { get; private set; }
        public string Battery { get; private set; }
        public Tesla(string model, string color, string batteries)
        { 
            Model = model;
            Color = color;
            Battery = batteries;
        }
        public string Start()
        {
            return $"{Model} color {Color} battery {Battery} is starting.";
        }
        public string Stop()
        {
            return $"{Model} color {Color} battery {Battery} is stopping.";
        }

    }
}
