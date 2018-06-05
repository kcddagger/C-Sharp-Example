using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace CustomerMaintenance
{
    /// <summary>
    /// Customer Database work
    /// </summary>
    public static class CustomerDB
	{
		private const string dir = @"C:\C# 2010\Files\";
		private const string path = dir + "Customers.txt";

        /// <summary>
        /// output customer list to an existing txt file
        /// </summary>
        /// <param name="customers">customers</param>
		public static void SaveCustomers(List<Customer> customers)
		{
			// create the output stream for a text file that exists
			StreamWriter textOut = 
				new StreamWriter(
				new FileStream(path, FileMode.Create, FileAccess.Write));

			// write each customer
			foreach (Customer customer in customers)
			{
				textOut.Write(customer.FirstName + "|");
				textOut.Write(customer.LastName + "|");
				textOut.WriteLine(customer.Email);
			}

			// write the end of the document
			textOut.Close();
		}

        /// <summary>
        /// getting the customer information and adding it to the array
        /// </summary>
        /// <returns>customer list</returns>
        public static List<Customer> GetCustomers()
		{
			// if the directory doesn't exist, create it
			if (!Directory.Exists(dir))
				Directory.CreateDirectory(dir);

			// create the object for the input stream for a text file
			StreamReader textIn = 
				new StreamReader(
					new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read));

			// create the array list for customers
            List<Customer> customers = new List<Customer>();

			// read the data from the file and store it in the ArrayList
			while (textIn.Peek() != -1)
			{
				string row = textIn.ReadLine();
				string[] columns = row.Split('|');
				Customer customer = new Customer();
				customer.FirstName = columns[0];
				customer.LastName = columns[1];
				customer.Email = columns[2];
				customers.Add(customer);
			}

			textIn.Close();

			return customers;
		}
	}
}
