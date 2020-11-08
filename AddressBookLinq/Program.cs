// --------------------------------------------------------------------------------------------------------------------
// <copyright file="fileName.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Your name"/>
// --------------------------------------------------------------------------------------------------------------------
namespace AddressBookLinq
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            // UC 1 Create a new table
            AddressBookTable addressBookTable = new AddressBookTable();

            // UC 4 Edit Existing Contact
            Console.WriteLine("After Editing Existing Contact");
            addressBookTable.EditExistingContact("Kamalakar", "Rao", "PhoneNumber", "8919810751");
            addressBookTable.GetAllContacts();

            // UC 5 Delete Existing Contact
            Console.WriteLine("\nAfter Deleting Contact");
            addressBookTable.DeleteContact("Apoorva", "Singh");
            addressBookTable.GetAllContacts();

            //UC 6 Retrieves the state or city.
            Console.WriteLine("\nRetrieves the state or city");
            addressBookTable.RetrieveByCityOrState("Delhi", "Delhi");

            //UC 7 Retrieves the state or city.
            Console.WriteLine("\nCount by the state or city");
            addressBookTable.CountByCityOrState("Kottayam", "Kerala");
        }
    }
}
