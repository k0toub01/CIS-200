// Program 1A
// CIS 200-01
// Fall 2021
// Due: 9/21/2020
// By: 5258426

// File: TestParcels.cs
// This is a simple, console application designed to exercise the Parcel hierarchy.
// It creates several different Parcels and prints them.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

namespace Prog1
{
    class TestParcels
    {
        // Precondition:  None
        // Postcondition: Parcels have been created and displayed
        static void Main(string[] args)
        {
            // Test Data - Magic Numbers OK
            Address a1 = new Address("  John Smith  ", "   123 Any St.   ", "  Apt. 45 ",
                "  Louisville   ", "  KY   ", 40202); // Test Address 1
            Address a2 = new Address("Jane Doe", "987 Main St.",
                "Beverly Hills", "CA", 90210); // Test Address 2
            Address a3 = new Address("James Kirk", "654 Roddenberry Way", "Suite 321",
                "El Paso", "TX", 79901); // Test Address 3
            Address a4 = new Address("John Crichton", "678 Pau Place", "Apt. 7",
                "Portland", "ME", 12302); // Test Address 4
            Address a5 = new Address("  Thing 2  ", "   987 Test Str   ", "  Apt. 9 ",
    "  Louisville   ", "  KY   ", 40121); // Test Address 5
            Address a6 = new Address("Bill Gates ", "142 Market St.",
                "Beverly Hills", "CA", 78121); // Test Address 6
            Address a7 = new Address("James Harden", "654 Berry Way", "Suite 13",
                "El Paso", "TX", 91231); // Test Address 7
            Address a8 = new Address("Dame Smith", "462 Alsem Str",
                "Portland", "ME", 01211 ); // Test Address 8

            Letter letter1 = new Letter(a1, a2, 3.95M);                            // Letter test object
            Letter letter2 = new Letter(a4, a3, 4.99m);
            Letter letter3 = new Letter(a1, a4, 2.01m);

            GroundPackage gp1 = new GroundPackage(a3, a4, 14, 10, 5, 12.5);        // Ground test object
            GroundPackage gp2 = new GroundPackage(a1, a7, 20, 10, 70, 12);
            GroundPackage gp3 = new GroundPackage(a2, a6, 40, 60, 10, 40);

            NextDayAirPackage ndap1 = new NextDayAirPackage(a8, a3, 25, 15, 15,    // Next Day test object
                85, 7.50M);
            NextDayAirPackage ndap2 = new NextDayAirPackage(a4, a7, 12, 45, 25,    // Next Day test object
                35, 12.50M);
            NextDayAirPackage ndap3 = new NextDayAirPackage(a5, a1, 30, 150, 65,    // Next Day test object
                95, 40.50M);

            TwoDayAirPackage tdap1 = new TwoDayAirPackage(a4, a8, 46.5, 39.5, 28.0, // Two Day test object
                80.5, TwoDayAirPackage.Delivery.Saver);
            TwoDayAirPackage tdap2 = new TwoDayAirPackage(a1, a7, 12.5, 34.5, 100.0, // Two Day test object
                100.5, TwoDayAirPackage.Delivery.Early);

            TwoDayAirPackage tdap3 = new TwoDayAirPackage(a7, a3, 36.5, 79.5, 75.4, // Two Day test object
                15, TwoDayAirPackage.Delivery.Saver);


            List<Parcel> parcels;      // List of test parcels

            parcels = new List<Parcel>();

            parcels.Add(letter1); // Populate list
            parcels.Add(gp1);
            parcels.Add(ndap1);
            parcels.Add(tdap1);

            parcels.Add(letter2);
            parcels.Add(gp2);
            parcels.Add(ndap2);
            parcels.Add(tdap2);

            parcels.Add(letter3);
            parcels.Add(gp3);
            parcels.Add(ndap3);
            parcels.Add(tdap3);


            WriteLine("Original List:");
            WriteLine("====================");
            foreach (Parcel p in parcels)
            {
                WriteLine(p);
                WriteLine("====================");
            }
            Pause();

            //Part 1 
            //Destination Zip from all Parcels and have them descending 
            var descZip = from p in parcels  //logics comes from the foreach loop above 
                          orderby p.DestinationAddress.Zip descending // in descending ordering 
                          select p; //all data entrys from parcels in list 
            WriteLine("Destination Address in Descending Order:"); // describing the what this fragment is doing 
            WriteLine("====================");
            foreach (Parcel p in descZip) // looping a read-only from parcel
            {
                WriteLine(p.DestinationAddress.Zip); // having the zip only display. 
            }
            WriteLine("====================");
            Pause();

            //Part 2
            WriteLine("Cost in ascending Order:"); // Cost in ascending order. 
            WriteLine("====================");
            var totalCost = from p in parcels // getting the total cost from parcels
                          orderby p.CalcCost() ascending //ascending is automatically done I just wanted to state the command
                          select p; //selecing all items in totalCost
            foreach (Parcel p in totalCost) // looping a read-only from Parcel to get the total cost 
            {
                WriteLine(p.CalcCost());  // having the total cost display 
            }
            WriteLine("====================");
            Pause();

            //Part 3
            WriteLine("Parcel Type in ascending order, and then cost in descending Order:"); // Cost in ascending order. 
            WriteLine("====================");
            var parTypeCost = from p in parcels // getting the parcel order and total cost from parcels
                              orderby p.GetType().ToString() ascending, p.CalcCost() descending
                              select p; //selecing all items in totalCost
            foreach (Parcel p in parTypeCost) // looping a read-only from Parcel to get the total cost 
            {
                WriteLine(p.GetType().ToString()+ " " + p.CalcCost());  //Displaying the Parcels and Cost 
            }
            WriteLine("====================");
            Pause();

            //Part 4 
            WriteLine("Parcel Type in ascending order, and then cost in descending Order:"); // Cost in ascending order. 
            WriteLine("====================");
            var airPackHeavy = from p in parcels // getting the parcel order and total cost from parcels
                               where (p is AirPackage) && ((AirPackage)p).IsHeavy() //Looking at AirPackages Only, and displaying if they are heavy
                               orderby ((AirPackage)p).Weight descending //desending
                               select p;


            foreach (AirPackage p in airPackHeavy) // looping a read-only from Parcel to get the total cost 
            {
                WriteLine(p.Weight);  //Displaying the Parcels and Cost 
            }
            WriteLine("====================");
            Pause();
        }

      
        // Precondition:  None
        // Postcondition: Pauses program execution until user presses Enter and
        //                then clears the screen
        public static void Pause()
        {
            WriteLine("Press Enter to Continue...");
            ReadLine();

            Console.Clear(); // Clear screen
        }
    }
}
