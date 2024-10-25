using System.ComponentModel.DataAnnotations;

namespace BlazorAssignment.Components.Pages
{
    public class User
    {
        public User()
        {
            
        }

        [Required(ErrorMessage = "Your name is required")]
        [StringLength(40, ErrorMessage = "To many characters")]
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public int PhoneNumber {  get; set; }

        public string Street { get; set; }
        public string City { get; set; }
        public int Zipcode { get; set; }

        public string CompanyName { get; set; }
        public string CompanyEmail { get; set; }
        public string CompanyCatchphrase { get; set; }
    }
}