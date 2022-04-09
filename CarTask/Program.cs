using CarTask.Models;
using System;

namespace CarTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Brand(out string brand);
            Model(out string model);
            Color(out string color);
            MaxSpeed(out double maxSpeed);
            PassengerCount(out int passengerCount);

            Buss buss1 = new Buss(brand, model, color, maxSpeed, passengerCount);
            Console.WriteLine(buss1.ShowInfo()); ;
            Console.ReadLine();
           

        }

        //Main methodunun sade gorsenmeyi uchun methodlara bolmushem
        static void Brand(out string brand)
        {
            Start:
            try
            {
                Console.WriteLine("Brendi daxil edin :");
                brand = Console.ReadLine();
                if (string.IsNullOrEmpty(brand) || string.IsNullOrWhiteSpace(brand))
                {
                    throw new Exception("Duzgun daxil edin");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto Start;
            }
        }
        static void Model(out string model)
        {
            Start:
            try
            {
                Console.WriteLine("Model daxil edin :");
                model = Console.ReadLine();
                if (string.IsNullOrEmpty(model) || string.IsNullOrWhiteSpace(model))
                {
                    throw new Exception("Duzgun daxil edin!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto Start;
            }
        }
        static void Color(out string color)
        {
            Start:
            try
            {
                Console.WriteLine("Color daxil edin :");
                color = Console.ReadLine();
                if (string.IsNullOrEmpty(color) || string.IsNullOrWhiteSpace(color))
                {
                    throw new Exception("Duzgun daxil edin!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto Start;
            }
        }
        static void MaxSpeed(out double maxSpeed)
        {
        Start:
            try
            {
                Console.WriteLine("Max Speed daxil edin :");
                maxSpeed = double.Parse(Console.ReadLine());
                if (maxSpeed<0)
                {
                    throw new Exception("Duzgun daxil edin!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto Start;
            }
        }
        static void PassengerCount(out int passengerCount)
        { 
            Start:
            try
            {
                Console.WriteLine("Sernishin sayi daxil edin :");
                passengerCount = int.Parse(Console.ReadLine());
                if (passengerCount<0 || passengerCount>50 )
                {
                    throw new Exception("Duzgun daxil edin!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto Start;
            }
        }
    }
}
