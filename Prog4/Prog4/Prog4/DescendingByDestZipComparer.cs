// Program 4
// CIS 200-01
// Fall 2018
// Due: 11/26/2018
// By: Andrew L. Wright (students use Grading ID)

// File: DescendingByDestZipComparer.cs
// Creates a Comparer for parcels that produces descending by destination zip.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class DescendingByDestZipComparer : Comparer<Parcel>
{
    // Precondition:  None
    // Postcondition: Returns 0 if p1.DestinationAddress.Zip = p2.Destination.Address.Zip
    //                      neg if p1.Destination.Address.Zip < p2.Destination.Address.Zip
    //                      pos if p1.Destination.Address.Zip > p2.Destination.Address.Zip
    public override int Compare(Parcel p1, Parcel p2)
    {
        int zip1; // p1's destination zip
        int zip2; // p2's destination zip

        // Implements correct handling of null values (in .NET, null less than anything)
        if (p1 == null && p2 == null) // Both null?
            return 0;

        if (p1 == null) // only this is null?
            return -1;

        if (p2 == null) // only p2 is null?
            return 1;

        zip1 = p1.DestinationAddress.Zip;
        zip2 = p2.DestinationAddress.Zip;

        return (-1) * zip1.CompareTo(zip2); // -1 reverses the order, creating desc
    }
}
