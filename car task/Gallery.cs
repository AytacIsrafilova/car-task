using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_task
{
    internal class Gallery
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public Car[]Cars=new Car[0];
        
        public void AddCar(Car car)
        {
            Array.Resize(ref Cars,Cars.Length+1);
            Cars[Cars.Length-1] = car;
        }

        
        public void ShowAllCars()
           
        {
            if (Cars.Length == 0)
            {
                Console.WriteLine("Hec bir car tapilmadi.");
                return;
            }

            Console.WriteLine("Butun carlar:");
            foreach (var car in Cars)
            {
                Console.WriteLine(ShowAllCars);
            }
        }
        public Car[]GetAllCars()
        { 
            return Cars;
        }
        public Car FindCarById(int id)
        {
            for(int i = 0; i < Cars.Length; i++)
            {
                if (Cars[i].Id == id) 
                {
                    return Cars[i];
                }
            }
            return null;

        }
        public Car FindCarByCarCode(string CarCode)
        {
            for (int i = 0; i < Cars.Length; i++)
            {
                if (Cars[i].CarCode == CarCode)
                {
                    return Cars[i];
                }
            }
            return null;
        }
        public Car[]FindCarsBySpeedInterval(int minSpeed,int maxSpeed)
        {
            Car[] carNew = new Car[] { };
            foreach (var car in Cars)
            {
                if(car.Speed>=minSpeed && car.Speed <= maxSpeed)
                {
                    Array.Resize(ref carNew, carNew.Length + 1);
                    carNew[carNew.Length-1] = car;
                }
            }
               
                
            return carNew;
        }


    }
}
