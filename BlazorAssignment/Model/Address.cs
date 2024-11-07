using System.ComponentModel.DataAnnotations;

namespace BlazorAssignment.Components.Pages
{
    public class Address
    {
        public Address(string street, string city, string zipcode)
        {
            Street = street;
            City = city;
            Zipcode = zipcode;
        }
        public string Street { get; set; }
        public string City { get; set; }

        [StringLength(5, ErrorMessage = "To many characters")]
        public string Zipcode { get; set; }
    }
}