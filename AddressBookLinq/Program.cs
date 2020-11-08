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
            addressBookTable.EditExistingContact("Kamalakar", "Rao", "PhoneNumber", "8919810751");
            addressBookTable.GetAllContacts();
        }
    }
}
