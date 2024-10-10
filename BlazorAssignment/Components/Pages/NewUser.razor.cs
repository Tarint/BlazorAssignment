using Microsoft.AspNetCore.Components;
using System.ComponentModel.DataAnnotations;
using System.Runtime.ExceptionServices;

namespace BlazorAssignment.Components.Pages
{
    public partial class NewUser
    {
        private User user = new User();

        private string _nameToDisplay;
        private bool _displayForm = true;

        private async Task ValidSubmissionAsync()
        {
            _displayForm = false;

            Console.WriteLine(DateTime.Now);
            await Task.Delay(10000);
            Console.WriteLine(DateTime.Now);
/*another comment*/

            _nameToDisplay = user.UserName ?? user.FirstName;                        
        }
    }




    public class User
    {
        public User()
        {
            BirthDay = new DateTime(1980, 01, 01);
        }

        [Required(ErrorMessage = "Your first name is required")]
        [StringLength(20, ErrorMessage = "To many characters")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Your last name is required")]
        [StringLength(20, ErrorMessage = "To many characters")]
        public string LastName { get; set; }

        public string UserName { get; set; }

        [Required(ErrorMessage = "Your age is required")]
        [Range(18, 100, ErrorMessage = "Age must be betwen 18 and 100")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Your birthday is required")]
        public DateTime BirthDay { get; set; }

        public string Email { get; set; }
    }

}