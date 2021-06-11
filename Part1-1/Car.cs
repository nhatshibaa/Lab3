using System;

namespace Part_1
{
    public class Car
    {
        public string make;
        public string model;
        public string color;
        public int yearBuilt;

        public void Start()
        {
            Console.WriteLine(model + " started");
        }

        public void Stop()
        {
            Console.WriteLine(model + " stopped");
        }
    }
}