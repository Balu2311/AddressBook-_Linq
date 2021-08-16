using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace AddressBookSystem_Linq
{
    class AddressBookDataTable
    {
        public readonly DataTable dataTable = new DataTable();
        public DataTable CreateTable(AddrssBookModel model)
        {
            var taleColumn1 = new DataColumn("First_Name");
            dataTable.Columns.Add(taleColumn1);
            var taleColumn2 = new DataColumn("Last_Name");
            dataTable.Columns.Add(taleColumn2);
            var taleColumn3 = new DataColumn("Address");
            dataTable.Columns.Add(taleColumn3);
            var taleColumn4 = new DataColumn("City");
            dataTable.Columns.Add(taleColumn4);
            var taleColumn5 = new DataColumn("State");
            dataTable.Columns.Add(taleColumn5);
            var taleColumn6 = new DataColumn("Zip");
            dataTable.Columns.Add(taleColumn6);
            var taleColumn7 = new DataColumn("Phone_Number");
            dataTable.Columns.Add(taleColumn7);
            var taleColumn8 = new DataColumn("Email");
            dataTable.Columns.Add(taleColumn8);
            
            dataTable.Rows.Add("Balu", "Reddy", "Lkdkr", "Ongl", "AP", "523115", "9876543210", "vbn@gmail.com");
            dataTable.Rows.Add("Siva", "Reddy", "N.Peta", "Gunturu", "AP", "526321", "6547890567", "siava@gmail.com");
            dataTable.Rows.Add("Dipika", "Pilli", "Chennai", "mahabaliPuram", "TN", "654342", "9632154564", "dipika@gmail.com");
            dataTable.Rows.Add("Mahesh", "Babu", "Banjarahiils", "Hyderabad", "TS", "500562", "8529631523", "mb@gmail.com");
            dataTable.Rows.Add("Vishal", "Gunni", "Marthali", "Banglore", "Karanataka", "500056", "9632544570", "vishal@gmail.com");
            dataTable.Rows.Add("Ganesh", "Reddy", "vesarpadi", "Chennai", "TamilNadu", "600341", "97456321011", "reddy@gmail.com");
            return dataTable;
        }
        public void Display()
        {
            foreach (var table in dataTable.AsEnumerable())
            {
                Console.WriteLine("\nFirstName: " + table.Field<string>("First_Name"));
                Console.WriteLine("LastName: " + table.Field<string>("Last_Name"));
                Console.WriteLine("Address: " + table.Field<string>("Address"));
                Console.WriteLine("City: " + table.Field<string>("City"));
                Console.WriteLine("State: " + table.Field<string>("State"));
                Console.WriteLine("ZipCode: " + table.Field<string>("Zip"));
                Console.WriteLine("PhoneNumber: " + table.Field<string>("Phone_Number"));
                Console.WriteLine("E-mail: " + table.Field<string>("Email"));
            }
        }
    }
}

