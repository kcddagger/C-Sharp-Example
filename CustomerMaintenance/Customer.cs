using System;

namespace CustomerMaintenance
{
    /// <summary>
    /// Getters and setters for the customer information and information display.
    /// </summary>
    public class Customer
	{
		private string firstName;
		private string lastName;
		private string email;

        /// <summary>
        /// default builder for Customer Class
        /// </summary>
        public Customer()
		{
		}

        /// <summary>
        /// Overloaded Builder for the Customer Class 
        /// </summary>
        /// <param name="firstName">firstName</param>
        /// <param name="lastName">lastName</param>
        /// <param name="email">email</param>
        public Customer(string firstName, string lastName, string email)
		{
			this.firstName = firstName;
			this.lastName = lastName;
			this.email = email;
		}

        /// <summary>
        /// firstName information
        /// </summary>
        public string FirstName
		{
			get
			{
				return firstName;
			}
			set
			{
                firstName = value;
			}
		}

        /// <summary>
        /// lastName information
        /// </summary>
        public string LastName
		{
			get
			{
				return lastName;
			}
			set
			{
				lastName = value;
			}
		}

        /// <summary>
        /// email information
        /// </summary>
        public string Email
		{
			get
			{
				return email;
			}
			set
			{
				email = value;
			}
		}


        /// <summary>
        /// Dsiplaying the information about the customer
        /// </summary>
        /// <returns>firstName lastName, email</returns>
        public string GetDisplayText()
		{
			return firstName + " " + lastName + ", " + email;
		}
	}
}