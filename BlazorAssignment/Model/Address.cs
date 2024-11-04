namespace BlazorAssignment.Components.Pages
{
    public class Address
    {
        public Address(string street, string city, int zipcode)
        {
            Street = street;
            City = city;
            Zipcode = zipcode;
        }
        public string Street { get; set; }
        public string City { get; set; }
        public int Zipcode { get; set; }
    }
}