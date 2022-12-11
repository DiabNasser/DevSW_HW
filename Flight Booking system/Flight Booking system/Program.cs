using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelHost
{
    class Program
    {
        static void Main(string[] args)
        {
            Passenger passenger = new Passenger();
            Reservation reservation = new Reservation();
            Flight flight = new Flight(); 

            while (true)
            {
                Console.WriteLine(".........................FLIGHT BOOKING MANAGER.....................");
                Console.WriteLine("\n");
                Console.WriteLine(
                      "Enter [1] to check available flights" + "\n"
                    + "Enter [2] to check free seats in two flights" + "\n"
                    + "Enter [3] to make new reservation" + "\n"
                    + "Enter [4] to show inforamtion of each passenger." + "\n"
                    + "Enter [5] to close. \n");
                Console.WriteLine("-------------------------\n");

                char state = Console.ReadKey().KeyChar;
                Console.WriteLine("\n");

                switch (state)
                {
                    case '1':
                        flight.ListOfFreeFlights();
                        break;
                    case '2':
                        Console.WriteLine("Available seats in flight (1)");
                        flight.ListOfFreeSeats_1();
                        Console.WriteLine("\n");
                        Console.WriteLine("Available seats in flight(2)");
                        flight.ListOfFreeSeats_2();
                        break;
                    case '3':
                        reservation.Booking();
                        break;
                    case '4':
                        Console.WriteLine("Passengers information in flight(1)");
                        flight.ListOfBookedseats_1();
                        Console.WriteLine("\n");
                        Console.WriteLine("Passengers information in flight(2)");
                        flight.ListOfBookedseats_2();
                        Console.WriteLine("\n");
                        break;
                    case '5':
                        return;

                    default:
                        Console.WriteLine("Please select only number from 1 to 5");
                        break;
                }
            }

        }
    }
}