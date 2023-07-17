using CarRental.Services;
using Entities;
using Services;

namespace CarRental.View
{
    internal class Menu
    {
        public static void TelaMenu()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Enter rental data\nCar Model: ");
            //string name = Console.ReadLine();
            string name = "Civic";

            Console.Write("Pickup (dd/MM/yyyy hh:mm): ");
            //DateTime datePickup = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy hh:mm", CultureInfo.InvariantCulture);
            DateTime datePickup = DateTime.Parse("25/06/2018 10:30");

            Console.Write("Return (dd/MM/yyyy hh:mm): ");
            //DateTime dateReturn = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy hh:mm", CultureInfo.InvariantCulture);
            DateTime dateReturn = DateTime.Parse("25/06/2018 14:40");

            Console.Write("Enter price per hour: ");
            //double priceHour = double.Parse(Console.ReadLine());
            double priceHour = 10;

            Console.Write("Enter price per day: ");
            //double priceDay = double.Parse(Console.ReadLine());
            double priceDay = 130;

            //CarRental r = new CarRental(name, datePickup, dateReturn, priceHour, priceDay);
            Console.WriteLine("DateReturn: " + dateReturn);

            Rental rental = new Rental(datePickup, dateReturn, new Vehicle(name));

            RentalService rentalService = new RentalService(priceHour, priceDay, new BrazilTaxService());

            rentalService.ProcessInvoice(rental);

            Console.WriteLine("INVOICE:\n" +
                rental.Invoice);
        }
    }
}
