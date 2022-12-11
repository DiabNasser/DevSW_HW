using System;
using System.Collections.Generic;

public class Passenger :Flight
{
    private static string passengerName;
    private static string phoneNumber;
    private static int passportNumber;
    private static int numberOfLuggage;


    public Passenger()
    {

    }

    public static string PassengerName { get => passengerName; set => passengerName = value; }
    public static int NumberOfLuggage { get => numberOfLuggage; set => numberOfLuggage = value; }
    //public static DateTime DepartureDateTime { get => departureDateTime; set => departureDateTime = value; }
    public static int PassportNumber { get => passportNumber; set => passportNumber = value; }
    public static string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }

}