namespace SRP.violation.Models
{
    public class CustomerAddress
    {
        private readonly string street;
        private readonly string city;
        private readonly string country;
        private readonly string zipCode;

        public CustomerAddress(string street, string city, string country, string zipCode)
        {
            this.street = street;
            this.city = city;
            this.country = country;
            this.zipCode = zipCode;
        }

        public override string ToString()
        {
            return $"{street}\n{city} {zipCode}\n{country}";
        }
    }
}