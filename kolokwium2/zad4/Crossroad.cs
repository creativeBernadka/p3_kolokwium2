using System;
using System.Collections.Generic;

namespace kolokwium2.zad4
{
    public class Crossroad
    {
        public event EventHandler Change;
        public List<TrafficSignal> TrafficSignals;

        public Crossroad()
        {
            TrafficSignals = new List<TrafficSignal>();
            Random rnd = new Random();
            for (int i = 0; i < 5; i++){
                int previousColor = rnd.Next(2);
                int currentColor = (previousColor + 1) % 3;
                TrafficSignals.Add(new TrafficSignal(currentColor, previousColor, rnd.Next(50)));            
            }
        }
    }
}