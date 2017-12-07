using System;
using System.Collections.Generic;
using System.Text;

namespace NewEventsTest
{
    public class DB
    {
        public void OnCustomerCreated(object source, CustomerEventArgs args)
        {
            Console.WriteLine("Writing customer with global id: {0} to the db", args.Customer.GlobalId);
        }
    }
}
