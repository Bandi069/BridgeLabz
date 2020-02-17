using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternPrograms.StructuralDesignPaytterns.FacadeProductDesign
{
    /// <summary>
    /// This is Address Book Class for Calling the different Methods
    /// </summary>
    public class AddressbookClass
    {
        /// <summary>
        /// This is the method to To call Operations of FacadeAddressBook
        /// </summary>
        public void AddressObject()
        {
            ////  Object Created for FacadeAddressBook
            FacadeAddressBook ObjAdd = new FacadeAddressBook();
            ObjAdd.FirstName(); //// Calling FirstName Method from FacadeAddressBook Class 
            ObjAdd.LastName();//// Calling LastName Method from FacadeAddressBook Class
            ObjAdd.Village();//// Calling Village Method from FacadeAddressBook Class
            ObjAdd.State();//// Calling State Method from FacadeAddressBook Class
            ObjAdd.Zipcode();//// Calling Zipcode Method from FacadeAddressBook class
            ObjAdd.PhoneNumber();//// Calling PhoneNumber Method from FacadeAddressBook class
        }
    }
}
