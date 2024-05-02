namespace Domain.ValueObjects;

public partial record Address
{
    public Address(string country, string street, string number, string city, string state, string zipCode)
    {
        Country = country;
        State = state;
        City = city;
        Street = street;
        Number = number;
        ZipCode = zipCode;
    }

    public string Country { get; init; }
    public string State { get; init; }
    public string City { get; init; }
    public string Street { get; init; }
    public string Number { get; init; }
    public string ZipCode { get; init; }

    public static Address? Create(string country, string Street, string Number, string city, string state, string zipCode)
    {
        if (string.IsNullOrEmpty(country) || string.IsNullOrEmpty(Street) ||
            string.IsNullOrEmpty(Number) || string.IsNullOrEmpty(city) ||
            string.IsNullOrEmpty(state) || string.IsNullOrEmpty(zipCode))
        {
            return null;
        }

        return new Address(country, Street, Number, city, state, zipCode);
    }
}