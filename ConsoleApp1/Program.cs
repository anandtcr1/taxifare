using ConsoleApp1.service;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            FareCalculatorService service = new FareCalculatorService();
            service.initializeFareBand();
            var fare = service.CalculateFare(2);
            Console.WriteLine("Fare for 2 mile - "+ fare.ToString());

            fare = service.CalculateFare(6);
            Console.WriteLine("Fare for 6 mile - " + fare.ToString());

            fare = service.CalculateFare(12);
            Console.WriteLine("Fare for 12 mile - " + fare.ToString());

            fare = service.CalculateFare(100);
            Console.WriteLine("Fare for 100 mile - " + fare.ToString());

        }

        

    }
}
