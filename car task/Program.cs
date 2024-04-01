namespace car_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Gallery gallery = new Gallery();
        }
        static void ShowMenu(Gallery gallery)
        {
            Console.WriteLine("Menu");
            Console.WriteLine($"1. Car elave et:");
            Console.WriteLine($"2. Id-e uygun car axtar:");
            Console.WriteLine($"3. CarCode-a uygun car axtar:");
            Console.WriteLine($"4. Suret araligina gore car axtar:");
            Console.WriteLine("0. Proqrami bitir!");
            Console.WriteLine(" ");
            Console.WriteLine("Secim edin!");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 0:
                    Console.WriteLine("Proqram bitirildi.");
                    break;
                case 1:
                    AddCar();
                    break;
                case 2:
                    gallery.FindCarById(4).ShowInfo();
                    break;
                case 3:
                    gallery.FindCarByCarCode("BM1001");
                    break;
                case 4:
                    gallery.FindCarsBySpeedInterval(100,200);
                    break;
                default:
                    Console.WriteLine($"Yanlis secim! Zehmet olmasa duzgun secim edin.");
                    break;
            }
        }
        static void AddCar()
        {
            Console.WriteLine($"carin adini daxil edin:");
            string Name=Console.ReadLine();
            Console.WriteLine($"carin id-ni daxil edin:");
            string FindCarById = Console.ReadLine();
            Console.WriteLine($"carin suretini daxil edin:");
            string Speed= Console.ReadLine();
            Console.WriteLine($"carcode daxil edin:");
            string CarCode=Console.ReadLine();
        }


    }
}

