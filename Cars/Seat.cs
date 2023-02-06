using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    internal class Seat : ICar
    {
        public string Model { get; private set; }
        public string Color { get; private set; }
        public Seat(string model, string color) 
        {
            Model = model;
            Color = color;
        }
        public string Start()
        {
            return $"{Model} color {Color} is start.";
        }
        public string Stop()
        {
            return $"{Model} color {Color} is stop.";
        }
    }
}
