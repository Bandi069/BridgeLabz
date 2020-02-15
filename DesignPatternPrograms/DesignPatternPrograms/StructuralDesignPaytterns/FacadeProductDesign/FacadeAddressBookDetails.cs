using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternPrograms.StructuralDesignPaytterns.FacadeProductDesign
{
    public interface  FacadeAddressBookDetails
    {
        public string FirstName();
        public string LastNAme();
        public string Village();
        public string City();
        public string State();

    }
}
