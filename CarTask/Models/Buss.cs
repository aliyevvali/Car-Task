using System;
using System.Collections.Generic;
using System.Text;

namespace CarTask.Models
{
    class Buss:Car
    {
        private int _passengerCount;
        public int PassengerCount {
            get => _passengerCount;
            set
            {
                if (value>0 && value<50)
                {
                    _passengerCount = value;
                }
            }
        }


        public Buss(string brand,string model,string color,double maxSpeed,int passengerCount):base(brand,model,color,maxSpeed)
        {
            PassengerCount = passengerCount;
        }
        public override string ShowInfo()
        {
            return base.ShowInfo() + $@"
Passenger count -->{PassengerCount}";
        }


    }
}
