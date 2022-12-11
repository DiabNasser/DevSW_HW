using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

public class Reservation : Passenger 
{

    public Reservation()
    {

    }

    int SeatCost;
    int LuggageCost;

    public void Booking()
    {
        
        Console.WriteLine("Enter Flight number :");
        Console.WriteLine("Enter 1 or 2");
        int FlightNumber = Console.ReadKey().KeyChar;
        Console.WriteLine("\n");
        //Flight.BookedFlights.Add(FlightNumber);
        
        switch (FlightNumber)
        {
            case '1':
                //Guest Name
                Console.WriteLine("Enter passenger name :");
                PassengerName = Console.ReadLine();
                Passenger.BookedSeats_1.Add(PassengerName);

                //p-number
                Console.WriteLine("Enter the passenger phone-number :");
                PhoneNumber = Console.ReadLine();
                Passenger.BookedSeats_1.Add(PhoneNumber);

                //number of passport
                Console.WriteLine("Enter number of passport :");
                PassportNumber = Convert.ToInt32(Console.ReadLine());
                Passenger.BookedSeats_1.Add(PassportNumber);

                //seat number
                Console.WriteLine("Enter seat number from 1 to 5 for first class or from 6 to 10 for economy :");
                SeatNumber = Convert.ToInt32(Console.ReadLine());

                if (SeatNumber < 6)
                {
                    SeatCost = 500;
                }
                else if (SeatNumber >= 6)
                {
                    SeatCost = 300;
                }
                while (!seat_1(SeatNumber))
                {
                    Passenger.BookedSeats_1.Add(SeatNumber);
                }

                //Number Of Luggage
                Console.WriteLine("Enter total number of luggage  :");
                NumberOfLuggage = Convert.ToInt32(Console.ReadLine());
                Passenger.BookedSeats_1.Add(NumberOfLuggage);
                if (NumberOfLuggage < 3)
                {
                    LuggageCost = NumberOfLuggage * 50;
                }
                else if (NumberOfLuggage >= 3)
                {
                    LuggageCost = NumberOfLuggage * 100;
                }

                //All costs
                Passenger.BookedSeats_1.Add(CostFunction(SeatCost, LuggageCost));
                Console.WriteLine("\n-------------------------------------------------------------------");
                Console.WriteLine("\n.........................Reservation is done.....................\n");
                break;
            case '2':
                //Guest Name
                Console.WriteLine("Enter passenger name :");
                PassengerName = Console.ReadLine();
                Passenger.BookedSeats_2.Add(PassengerName);

                //p-number
                Console.WriteLine("Enter the passenger phone-number :");
                PhoneNumber = Console.ReadLine();
                Passenger.BookedSeats_2.Add(PhoneNumber);

                //number of passport
                Console.WriteLine("Enter number of passport :");
                PassportNumber = Convert.ToInt32(Console.ReadLine());
                Passenger.BookedSeats_2.Add(PassportNumber);

                //seat number
                Console.WriteLine("Enter seat number from 1 to 5 for first class or from 6 to 10 for economy :");
                SeatNumber = Convert.ToInt32(Console.ReadLine());

                if (SeatNumber < 6)
                {
                    SeatCost = 500;
                }
                else if (SeatNumber >= 6)
                {
                    SeatCost = 300;
                }
                while (!seat_2(SeatNumber))
                {
                    Passenger.BookedSeats_2.Add(SeatNumber);
                }


                //Number Of Luggage
                Console.WriteLine("Enter total number of luggage  :");
                NumberOfLuggage = Convert.ToInt32(Console.ReadLine());
                Passenger.BookedSeats_2.Add(NumberOfLuggage);
                if (NumberOfLuggage < 3)
                {
                    LuggageCost = NumberOfLuggage * 50;
                }
                else if (NumberOfLuggage >= 3)
                {
                    LuggageCost = NumberOfLuggage * 100;
                }

              
                //All costs
                Passenger.BookedSeats_2.Add(CostFunction(SeatCost, LuggageCost));
                Console.WriteLine("\n-------------------------------------------------------------------");

                Console.WriteLine("\n.........................Reservation is done.....................\n");
                break;
            default:
                Console.WriteLine("Please select only 1 or 2");
                break;

        }

    }

    public double CostFunction(int SeatCost, int LuggageCost)

    {
        double cost = LuggageCost + SeatCost;
        return cost;
    }

    public bool seat_1(int seat)
    {
        if (Passenger.UnBookedseats_1.Contains(seat))
        {
            int numToRemove = seat;
            Passenger.UnBookedseats_1 = Passenger.UnBookedseats_1.Where(val => val != numToRemove).ToArray();
            Passenger.BookedSeats_1.Add(seat);
            return true;
        }
        else
        {
            Console.WriteLine("The seat has booked, please select another one :");
            SeatNumber = Convert.ToInt32(Console.ReadLine());

        }

        return false;
    }



    public bool seat_2(int seat)
    {
        if (Passenger.UnBookedseats_2.Contains(seat))
        {
            int numToRemove = seat;
            Passenger.UnBookedseats_2 = Passenger.UnBookedseats_2.Where(val => val != numToRemove).ToArray();
            Passenger.BookedSeats_2.Add(seat);
            return true;
        }
        else
        {
            Console.WriteLine("The seat has booked, please select another one :");
            SeatNumber = Convert.ToInt32(Console.ReadLine());

        }

        return false;

    }

}