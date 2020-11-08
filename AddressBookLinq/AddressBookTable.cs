﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="fileName.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Your name"/>
// --------------------------------------------------------------------------------------------------------------------
namespace AddressBookLinq
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;
    using System.Text;

    public class AddressBookTable
    {
        // UC 1 Create a new DataTable
        DataTable table = new DataTable("AddressBook");

        /// <summary>
        /// UC 2 Initializes a new instance of the <see cref="AddressBookTable"/> class.
        /// </summary>
        public AddressBookTable()
        {
            table.Columns.Add("FirstName", typeof(string));
            table.Columns.Add("LastName", typeof(string));
            table.Columns.Add("Address", typeof(string));
            table.Columns.Add("City", typeof(string));
            table.Columns.Add("State", typeof(string));
            table.Columns.Add("Zip", typeof(string));
            table.Columns.Add("PhoneNumber", typeof(string));
            table.Columns.Add("Email", typeof(string));

            // UC 3 Inserting Data
            table.Rows.Add("Kamalakar", "Rao", "Pala", "Kottayam", "Kerala", "686574", "9595959595", "kamalakar.Rao");
            table.Rows.Add("Vishal", "Garg", "Barwala", "Hisar", "Haryana", "125121", "8570934858", "vishal.garg");
            table.Rows.Add("Akshay", "Poriya", "Goregaon", "Bangalore", "Karnataka", "125433", "8585858585", "akshay.a");
            table.Rows.Add("Kretika", "Arora", "Andheri", "Mumbai", "Maharashtra", "125445", "7575757575", "kretika.arora");
            table.Rows.Add("Praveen", "Kumar", "rohini", "Delhi", "Delhi", "435121", "7897897898", "praveen.kumar");
            table.Rows.Add("Apoorva", "Singh", "Andheri", "Mumbai", "Maharashtra", "125445", "8598598599", "apporva.singh");
        }

        public void GetAllContacts(DataRow[] dt = null)
        {
            Console.WriteLine("\n\n");
            if(dt == null)
            {
                foreach (DataRow dr in table.AsEnumerable())
                {
                    Console.WriteLine("\n\n");
                    Console.WriteLine("FirstName:- " + dr.Field<string>("firstName"));
                    Console.WriteLine("lastName:- " + dr.Field<string>("lastName"));
                    Console.WriteLine("Address:- " + dr.Field<string>("address"));
                    Console.WriteLine("City:- " + dr.Field<string>("city"));
                    Console.WriteLine("State:- " + dr.Field<string>("state"));
                    Console.WriteLine("zip:- " + dr.Field<string>("zip"));
                    Console.WriteLine("phoneNumber:- " + dr.Field<string>("phoneNumber"));
                    Console.WriteLine("Email:- " + dr.Field<string>("Email"));
                }
            }
            else
            {
                foreach (DataRow dr in dt)
                {
                    Console.WriteLine("\n\n");
                    Console.WriteLine("FirstName:- " + dr.Field<string>("firstName"));
                    Console.WriteLine("lastName:- " + dr.Field<string>("lastName"));
                    Console.WriteLine("Address:- " + dr.Field<string>("address"));
                    Console.WriteLine("City:- " + dr.Field<string>("city"));
                    Console.WriteLine("State:- " + dr.Field<string>("state"));
                    Console.WriteLine("zip:- " + dr.Field<string>("zip"));
                    Console.WriteLine("phoneNumber:- " + dr.Field<string>("phoneNumber"));
                    Console.WriteLine("eMail:- " + dr.Field<string>("eMail"));
                }
            }
        }

        /// <summary>
        /// UC 4 Edits the existing contact.
        /// </summary>
        /// <param name="firstName">The first name.</param>
        /// <param name="lastName">The last name.</param>
        /// <param name="column">The column.</param>
        /// <param name="newValue">The new value.</param>
        public void EditExistingContact(string firstName, string lastName, string column, string newValue)
        {
            try
            {
                DataRow contact = table.Select("FirstName = '" + firstName + "' and LastName = '" + lastName + "'").FirstOrDefault();
                contact[column] = newValue;
            }
            catch
            {

            }
           
        }

        /// <summary>
        /// UC 5 Deletes the contact.
        /// </summary>
        /// <param name="firstName">The first name.</param>
        /// <param name="lastName">The last name.</param>
        public void DeleteContact(string firstName,string lastName)
        {
            try
            {
                DataRow contact = table.Select("FirstName = '" + firstName + "' and LastName = '" + lastName + "'").FirstOrDefault();
                table.Rows.Remove(contact);
            }
            catch
            {

            }
            
        }

        /// <summary>
        /// UC 6 Retrieves the state or city.
        /// </summary>
        /// <param name="city">The city.</param>
        /// <param name="state">The state.</param>
        public void RetrieveByCityOrState(string city, string state)
        {
            var contact = from c in table.AsEnumerable()
                          where c.Field<string>("City") == city && c.Field<string>("State") == state
                          select c;

            if(contact.Count() != 0)
                GetAllContacts(contact.ToArray());
        }

        /// <summary>
        /// UC 7 Counts the state of the by city or.
        /// </summary>
        /// <param name="city">The city.</param>
        /// <param name="state">The state.</param>
        public void CountByCityOrState(string city, string state)
        {
            var contact = from c in table.AsEnumerable()
                          where c.Field<string>("City") == city && c.Field<string>("State") == state
                          select c;

            Console.WriteLine("Count of contacts in {0}, {1} is {2}", city,state,contact.Count());
        }
    }
}
