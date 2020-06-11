using System;

namespace AutoInspect
{
    class Program
    {
        static void Main()
        {
            // Array von Autos
            Car[] cars = new Car[6];
            cars[0] = new Car("Mercedes G", 2008);
            cars[1] = new Car("BMW 3", 2001);
            cars[2] = new Car("Audi A6", 2005);
            cars[3] = new Car("Audi A8", 2012);
            cars[4] = new Car("Hyundai", 2003);
            cars[5] = new Car("Honda Civic", 1995);

            Console.WriteLine("Bitte geben Sie einen Suchbegriff ein");
            string searchTerm = Console.ReadLine();
            Console.WriteLine("Suchbegriff ist: " + searchTerm);
            Console.WriteLine("Folgende Autos wurden gefunden:");

            foreach(Car car in cars)
            {
                if(car.carName.Contains(searchTerm))
                {
                    Console.WriteLine(car.carName + " Baujahr: " + car.baujahr + " Letzte Inspection: " + car.lastInspectionYear);
                    car.Inspect();
                    Console.WriteLine("Neues Inspektionsdatum: " + car.lastInspectionYear);
                }
            }
            Console.ReadKey();
            Console.Clear();
            Main();
        }
    }
}
