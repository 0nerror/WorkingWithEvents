using System;
using System.Threading;

namespace NewEventsTest
{
    public class CustomerCreator
    {
        public EventHandler<CustomerEventArgs> CustomerCreated;
        public void Create(Customer customer)
        {
            Console.WriteLine("Creating new customer...");
            Thread.Sleep(3000);

            OnCustomerCreated(customer);
        }

        protected virtual void OnCustomerCreated(Customer customer)
        {
            if(CustomerCreated != null )
            {
                CustomerCreated(this, new CustomerEventArgs() {Customer =  customer});
            }
        }
    }
}
