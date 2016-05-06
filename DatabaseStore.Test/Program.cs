using DatabaseStore.EF;
using DatabaseStore.Model;
using System;

namespace DatabaseStore.Test
{
    class Program
    {
        static void Main(string[] args)
        {
           DbContextQueryManager<Customer> customer = new DbContextQueryManager<Customer>();
            DbContextQueryManager<Address> address = new DbContextQueryManager<Address>();

            Address newAddress = new Address { Id =1, Street="Meciano", City="Dumaguete", Country="Philippines" };
            address.Add(newAddress);

            Customer newCustomer = new Customer { Id = 1, FirstName= "Ian", LastName="Canto", CreatedDate = DateTime.Now, Address = newAddress };
            customer.Add(newCustomer);

            customer.GetAll();

        }
    }
}
