using System;
using SRP.violation.Models;

namespace SRP.violation.App
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer("Daniel Rusnok", "123456789", "daniel.rusnok@email.com", "Elm street", "Los Angeles", "Kambodža", "45 888");
            var address = customer.GetCustomerAddress();
            Console.WriteLine(address);
            Console.ReadKey();
        }
    }
}
