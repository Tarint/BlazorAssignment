using Microsoft.AspNetCore.Components;
using System.Runtime.ExceptionServices;

namespace BlazorAssignment.Components.Pages
{
    public partial class NewUser
    {
        private UserData user = new UserData(0, null, null, null, null, new Address(null, null, null), new Company(null, null));


        private string _nameToDisplay;

        private string _name;
        private string _userName;
        private string _email;
        private string _phoneNumber;

        private string _street;
        private string _city;
        private string _zipcode;

        private string _companyName;
        private string _companyCatchphrase;

        private bool _displayForm = true;
        private async Task ValidSubmissionAsync()
        {
            _displayForm = false;

            _nameToDisplay = user.UserName ?? user.Name;  
            
            _name = user.Name;
            _userName = user.UserName;
            _email = user.Email;
            _phoneNumber = user.PhoneNumber;

            _street = user.Adress.Street;
            _city = user.Adress.City;
            _zipcode = user.Adress.Zipcode;

            _companyName = user.Commpany.CompanyName;
            _companyCatchphrase = user.Commpany.CompanyCatchphrase;
        }
    }
}