using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


namespace OOPS
{
    class AddressDetails
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Village { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zipcode { get; set; }
        public int PhoneNumber { get; set; }

    }
    public class AddressBookList
    {
        internal List<AddressDetails> AddressBook { get; set; }
        private List<AddressDetails> addressBook { get; set; }

      /*  public List<AddressDetails> GetAddressBook()
        {
            return addressBook;
        }

        public void SetAddressBook(List<AddressDetails> value)
        {
            addressBook = value;
        }*/
    }
    
}

