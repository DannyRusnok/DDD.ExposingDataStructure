namespace SRP.violation.Models
{
    public class Customer
    {
        public string Name { get; private set; }
        public string PhoneNumber { get; private set; }
        public string EmailAddress { get; private set; }
        public string Street { get; private set; }
        public string City { get; private set; }
        public string Country { get; private set; }
        public string ZipCode { get; private set; }

        public Customer(string name, string phoneNumber, string emailAddress, string street, string city, string country, string zipCode)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            EmailAddress = emailAddress;
            Street = street;
            City = city;
            Country = country;
            ZipCode = zipCode;
        }

        public CustomerAddress GetCustomerAddress()
        {
            return new CustomerAddress(this.Street, this.City, this.Country, this.ZipCode);
        }
    }
}