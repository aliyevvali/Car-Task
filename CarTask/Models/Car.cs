using System;
using System.Collections.Generic;
using System.Text;

namespace CarTask.Models
{
    class Car
    {
        private string _brand;
        private string _model;
        private string _color;
        private double _maxSpped;
        public string Brand {
            get => _brand;
           
            set
            {
                if (!string.IsNullOrEmpty(value) && !string.IsNullOrWhiteSpace(value)) _brand = value;
                
            }
        }
        public string Model {
            get => _model;
            set
            {
                if (!string.IsNullOrEmpty(value) && !string.IsNullOrWhiteSpace(value)) _model = value;
            } 
        }
        public string Color {
            get => _color;
            set
            {
                if (!string.IsNullOrEmpty(value) && !string.IsNullOrWhiteSpace(value)) _color = value;              
            }
        }
        public double MaxSpeed {
            get => _maxSpped;
            set
            {
                if (value>0)
                {
                    _maxSpped = value;
                }
            }
        }

        public Car()
        {
            Console.WriteLine("Car Created");
        }
        public Car(string brand,string model)
        {
            Brand = brand;
            Model = model;
        }
        public Car(string brand, string model,string color,double maxSpeed):this(brand,model)
        {
            Color = color;
            MaxSpeed = maxSpeed;
        }


        public virtual string ShowInfo()
        {
            return $@"Brand -->{Brand}
Model -->{Model}
Color -->{Color}
Max speed -->{MaxSpeed}";
        }
    }
}
