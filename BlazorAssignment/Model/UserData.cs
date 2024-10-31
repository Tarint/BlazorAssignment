using System.ComponentModel.DataAnnotations;

namespace BlazorAssignment.Components.Pages
{
    public class UserData
    {
        public UserData(int iD, string name, string userName, string email, long phoneNumber, string street, string city, int zipcode, string companyName, string companyCatchphrase)
        {
            ID = iD;
            
            Name = name;
            UserName = userName;
            Email = email;
            PhoneNumber = phoneNumber;

            Street = street;
            City = city;
            Zipcode = zipcode;

            CompanyName = companyName;
            CompanyCatchphrase = companyCatchphrase;
        }

        public int ID { get; set; }

        [Required(ErrorMessage = "Your name is required")]
        [StringLength(40, ErrorMessage = "To many characters")]
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public long PhoneNumber {  get; set; }

        public string Street { get; set; }
        public string City { get; set; }
        public int Zipcode { get; set; }

        public string CompanyName { get; set; }
        public string CompanyCatchphrase { get; set; }
    }
}