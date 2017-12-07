using System;

namespace NewEventsTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer newCustomer = new Customer() { GlobalId = Guid.NewGuid().ToString() };
            CustomerCreator CustomerCreator = new CustomerCreator();
            DB DB = new DB();
            CustomerCreator.CustomerCreated += DB.OnCustomerCreated;
           
            CustomerCreator.Create(newCustomer);
        }
    }
}
