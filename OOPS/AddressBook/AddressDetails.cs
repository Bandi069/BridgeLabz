using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


namespace OOPS
{
    /// <summary>
    /// this is Address Details Class
    /// </summary>
  public  class AddressDetails
    {
        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        /// <value>
        /// The first name.
        /// </value>
        public string FirstName { get; set; }
        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        /// <value>
        /// The last name.
        /// </value>
        public string LastName { get; set; }
        /// <summary>
        /// Gets or sets the village.
        /// </summary>
        /// <value>
        /// The village.
        /// </value>
        public string Village { get; set; }
        /// <summary>
        /// Gets or sets the city.
        /// </summary>
        /// <value>
        /// The city.
        /// </value>
        public string City { get; set; }
        /// <summary>
        /// Gets or sets the state.
        /// </summary>
        /// <value>
        /// The state.
        /// </value>
        public string State { get; set; }
        /// <summary>
        /// Gets or sets the zipcode.
        /// </summary>
        /// <value>
        /// The zipcode.
        /// </value>
        public int Zipcode { get; set; }
        /// <summary>
        /// Gets or sets the phone number.
        /// </summary>
        /// <value>
        /// The phone number.
        /// </value>
        public int PhoneNumber { get; set; }

    }
    /// <summary>
    /// This is Address Book list Class
    /// </summary>
    public class AddressBookList
    {
        /// <summary>
        /// Gets or sets the address book.
        /// </summary>
        /// <value>
        /// The address book.
        /// </value>
        public List<AddressDetails> AddressBook { get; set; }
        /// <summary>
        /// Gets or sets the address book.
        /// </summary>
        /// <value>
        /// The address book.
        /// </value>
        private List<AddressDetails> addressBook { get; set; }
        /// <summary>
        /// This is List of Address Book class
        /// </summary>
        public class ListOfAddressBook
        {
            /// <summary>
            /// Gets or sets the address book.
            /// </summary>
            /// <value>
            /// The address book.
            /// </value>
            public List<AddressDetails> AddressBook { get; set; }
        }
    }
    
}

