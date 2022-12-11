using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Flight 
{
    private static ArrayList bookedSeats_1 = new ArrayList();
    private static int[] unBookedseats_1 = Enumerable.Range(1, 10).ToArray();
    private static ArrayList bookedSeats_2 = new ArrayList();
    private static int[] unBookedseats_2 = Enumerable.Range(1, 10).ToArray();
    private static int seatNumber;
    private static int flightNumber;
    private static int[] availableFlights = Enumerable.Range(1, 2).ToArray();
 


    public Flight()
    {

    }

    public static ArrayList BookedSeats_1 { get => bookedSeats_1; set => bookedSeats_1 = value; }
    public static int[] UnBookedseats_1 { get => unBookedseats_1; set => unBookedseats_1 = value; }
    public static ArrayList BookedSeats_2 { get => bookedSeats_2; set => bookedSeats_2 = value; }
    public static int[] UnBookedseats_2 { get => unBookedseats_2; set => unBookedseats_2 = value; }
    public static int SeatNumber { get => seatNumber; set => seatNumber = value; }
    public static int FlightNumber { get => flightNumber; set => flightNumber = value; }
    public static int[] AvailableFlights { get => availableFlights; set => availableFlights = value; }



    /*public void ListOfBookedFlights()
    {
        int counter = 1;
        if (BookedFlights.Count == 0)
        {
            Console.WriteLine("all flights are available");
        }
        else
        {
            Console.WriteLine("Flighta");

            for (int i = 0; i < BookedFlights.Count; i++)
            {
                Console.Write(BookedFlights[i] + "\n");

                counter++;
            }
        }

    }*/

    public void ListOfFreeFlights()
    {
        int counter = 1;
        for (int i = 0; i < availableFlights.Length; i++)
        {
            if (i == 1) { Console.Write("Flight number [" + availableFlights[i] + "] is availabe today 112:00 pm to EGYPT \n"); }
            else { Console.Write("Flight number [" + availableFlights[i] + "] is availabe today 10:00 am to EGYPT \n"); }
            Console.WriteLine("\n");
            counter++;
        }
    }

    public void ListOfBookedseats_1()
    {
        int counter = 1;

            Console.WriteLine("passengername|Phone -number |Passport |Seat | Luggage |Cost $");
 for (int i = 0; i < bookedSeats_1.Count; i++)
            {
                Console.Write(bookedSeats_1[i] + "\t");
                if (counter > 5)
                {
                    Console.WriteLine("\n");
                    counter = 0;
                }
                counter++;
            }  
    }
    public void ListOfFreeSeats_1()
    {
        int counter = 1;
        for (int i = 0; i < UnBookedseats_1.Length; i++)
        {
            Console.Write("Seat number [" + UnBookedseats_1[i] + "] is free \t");
            if (counter == 2)
            {
                Console.WriteLine("\n");
                counter = 0;
            }
            counter++;
        }
    }

    public void ListOfBookedseats_2()
    {
        int counter = 1;

            Console.WriteLine("passengername|Phone -number |Passport |Seat  | Luggage |Cost $");
            
            for (int i = 0; i < bookedSeats_2.Count; i++)
            {
                Console.Write(bookedSeats_2[i] + "\t");
                if (counter > 5)
                {
                    Console.WriteLine("\n");
                    counter = 0;
                }
                counter++;
            }
    }

    public void ListOfFreeSeats_2()
    {
        int counter = 1;
        for (int i = 0; i < UnBookedseats_2.Length; i++)
        {
            Console.Write("Seat number [" + UnBookedseats_2[i] + "] is free \t");
            if (counter == 2)
            {
                Console.WriteLine("\n");
                counter = 0;
            }
            counter++;
        }
    }
}