// <snippet_Customer>
using System;
using System.Collections.Generic;

namespace CollectionViewSourceExample
{
    // The Customer class defines a simple Customer business object.
    public class Customer
    {
        // Default constructor is required for usage as sample data 
        // in the Visual Studio designer.
        public Customer() {}

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Guid CustomerID { get; set; }
        public int Age { get; set; }
    }

    // The CustomerCollection class defines a simple collection
    // for Customer business objects.
    public class CustomerCollection : List<Customer>
    {
        // Default constructor is required for usage in the VS Designer.
        public CustomerCollection() { }
    }
}
// </snippet_Customer>