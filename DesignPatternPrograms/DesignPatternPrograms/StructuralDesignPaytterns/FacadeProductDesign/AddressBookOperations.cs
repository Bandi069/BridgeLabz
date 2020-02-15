using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternPrograms.StructuralDesignPaytterns.FacadeProductDesign
{
    /// <summary>
    /// This is Address book Operations Interface Class
    /// </summary>
    public interface FacadeAddressBookOperations
    {
        /// <summary>
        /// This is Method for getting Address Book user Details
        /// </summary>
        public void UserDetails();
        /// <summary>
        /// This is Method for Adding the user to Address Book
        /// </summary>
        public void AddUser();
        /// <summary>
        /// This is method for Update the user details in Address Book
        /// </summary>
        public void UpdateUSer();
        /// <summary>
        /// This is method for Removing user from Address Book
        /// </summary>
        public void RemoveUser();



    }
}
