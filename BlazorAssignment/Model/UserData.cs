using System.ComponentModel.DataAnnotations;

namespace BlazorAssignment.Components.Pages
{
    public class UserData
    {
        public UserData(int iD, string name, string userName, string email, string phoneNumber, Address address, Company company)
        {
            ID = iD; 

            Name = name;
            UserName = userName;
            Email = email;
            PhoneNumber = phoneNumber;

            Adress = address;

            Commpany = company;
        }

        public int ID { get; set; }

        [Required(ErrorMessage = "Your name is required")]
        [StringLength(40, ErrorMessage = "To many characters")]
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }

        [Required(ErrorMessage = "Your name is required")]
        [StringLength(11, ErrorMessage = "To many characters")]
        public string PhoneNumber {  get; set; }

        public Address Adress { get; set; }

        public Company Commpany { get; set; }
    }
}