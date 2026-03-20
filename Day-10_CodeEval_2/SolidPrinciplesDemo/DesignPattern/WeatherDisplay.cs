using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciplesDemo.DesignPattern
{
    class WeatherDisplay : IObserver
    {
        public void Update(int temperature)
        {
            Console.WriteLine("Temperature Updated: " + temperature);
        }
    }
}
