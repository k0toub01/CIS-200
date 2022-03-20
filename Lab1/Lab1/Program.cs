//Student ID: 5258426
//CIS 200-50 
//Completed on September 16
//Lab 1
//Using LINQ to sort items
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

namespace Lab1
{
    public class LinqTest
    {
        public static void Main(string[] args)
        {
            // initialize array of invoices
            Invoice[] invoices = {
                new Invoice( 83, "Electric sander", 7, 57.98M ),
                new Invoice( 24, "Power saw", 18, 99.99M ),
                new Invoice( 7, "Sledge hammer", 11, 21.5M ),
                new Invoice( 77, "Hammer", 76, 11.99M ),
                new Invoice( 39, "Lawn mower", 3, 79.5M ),
                new Invoice( 68, "Screwdriver", 106, 6.99M ),
                new Invoice( 56, "Jig saw", 21, 11M ),
                new Invoice( 3, "Wrench", 34, 7.5M ) };

            // Display original array
            WriteLine("Original Invoice Data\n");
            WriteLine("P.Num Part Description     Quant Price"); // Column Headers
            WriteLine("----- -------------------- ----- ------");

            foreach (Invoice inv in invoices)
                WriteLine(inv);

            //Sorting by PartDescription
            WriteLine("\n Sorting by part Description (Lowest Part Number to Greatest)"); // Will start at the largest number decrease
            var part = from inv in invoices
                       orderby inv.PartDescription descending
                       select inv;
            foreach (Invoice inv in part) 
            {
                WriteLine(inv);
            }

            //Sorting by Price
            WriteLine("\n Sorting by Price (Lowest Price to Greatest Price)"); //lowest to highest price
            var price = from inv in invoices
                        orderby inv.Price
                        select inv;
            foreach (Invoice inv in price)
            {
                WriteLine(inv);
            }

            WriteLine("\n Sorting by Quantity"); //Sorting by Quantity
            var quantity = from inv in invoices
                        orderby inv.Quantity
                        select new {inv.PartDescription, inv.Quantity};
            foreach (var obj in quantity)
            {
                WriteLine(obj);
            }

            WriteLine("\n Invoice total"); //Total price of how many parts there are multipled by the quantity
            var invoiceTotal = from inv in invoices let total = inv.Price * inv.Quantity
                               orderby total
                               select new { inv.PartDescription, inv.PartNumber, inv.Price, inv.Quantity, InvoiceTotal = total };
            foreach (var obj in invoiceTotal)
            {
                WriteLine(obj);
            }

            WriteLine("\n Price Range of 200 to 500"); //will only display values within the range of 200 to 500
            var priceRange = from inv in invoiceTotal
                             where (inv.InvoiceTotal >= 200) && (inv.InvoiceTotal <= 500)
                             select inv;
            foreach (var obj in priceRange)
            {
                WriteLine(obj);
            }
        }
    }
}
