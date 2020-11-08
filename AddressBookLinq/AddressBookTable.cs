// --------------------------------------------------------------------------------------------------------------------
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
    }
}
