using Microsoft.AspNetCore.Components;
using System.Runtime.ExceptionServices;

namespace BlazorAssignment.Components.Pages
{
    public partial class NewUser
    {
        private UserData user = new UserData(0, null, null, null, 0, null, null, 0, null, null);


        private string _nameToDisplay;
        private bool _displayForm = true;
        private async Task ValidSubmissionAsync()
        {
            _displayForm = false;

            _nameToDisplay = user.UserName ?? user.Name;                        
        }
    }
}