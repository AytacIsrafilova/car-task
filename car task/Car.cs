using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_task
{
    internal class Car
    {
         
        public string Name;
        public int Speed;
        public string CarCode { get; set; }
        private  static int _id=1000;
        public int Id;
        public Car(string name)
        {
            _id++;
            Id=_id;
            if (name.Length >= 2)
                CarCode = name.Substring(0, 2).ToUpper() + Id;
            else
                CarCode = "XX" + Id; 
            Console.WriteLine(CarCode);
           
        }
        public Car(string name,int speed,string carcode)
        {
            Name = name;
            Speed = speed;
            CarCode = carcode;

        }
        public void  ShowInfo()
        {
            Console.WriteLine($"{Name},{Speed},{CarCode},{Id}");
        }




    }
}
