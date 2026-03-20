using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciplesDemo.DesignPattern
{
    class WeatherStation
    {
        private List<IObserver> observers = new List<IObserver>();
        private int temperature;

        public void Register(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Unregister(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void SetTemperature(int temp)
        {
            temperature = temp;
            Notify();
        }

        private void Notify()
        {
            foreach (var observer in observers)
            {
                observer.Update(temperature);
            }
        }
    }
}
