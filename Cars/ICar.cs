using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    internal interface ICar
    {
        string Model { get; }
        string Color { get; }
        public void Start() { }
        public void Stop() { }  
    }
}
