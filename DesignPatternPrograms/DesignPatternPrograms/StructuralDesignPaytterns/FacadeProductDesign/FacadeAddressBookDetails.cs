using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternPrograms.StructuralDesignPaytterns.FacadeProductDesign
{
    /// <summary>
    /// Interface for the Addressbook
    /// </summary>
    public interface FacadeAddressBookDetails
    {
        /// <summary>
        /// Method Instance of FirstName
        /// </summary>
        /// <returns></returns>
        public string FirstName();
        /// <summary>
        /// This method is Instance for LastName
        /// </summary>
        /// <returns></returns>
        public string LastName();
        /// <summary>
        /// Method for Instance of Village
        /// </summary>
        /// <returns></returns>
        public string Village();
        /// <summary>
        /// This is method for City
        /// </summary>
        /// <returns></returns>
        public string City();
        /// <summary>
        /// This is MEthod for State
        /// </summary>
        /// <returns></returns>
        public string State();
        /// <summary>
        /// This is Method for Zipcode
        /// </summary>
        /// <returns></returns>
        public int Zipcode();
        /// <summary>
        /// This is MEthod for Phone Number
        /// </summary>
        /// <returns></returns>
        public int PhoneNumber();

    }
}
