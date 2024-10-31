using Microsoft.AspNetCore.Components;
using System.Runtime.ExceptionServices;

namespace BlazorAssignment.Components.Pages
{
    public partial class NewUser
    {
        private UserData user = new UserData();


        private string _nameToDisplay;
        private bool _displayForm = true;
        private async Task ValidSubmissionAsync()
        {
            _displayForm = false;

            Console.WriteLine(DateTime.Now);
            await Task.Delay(5000);
            Console.WriteLine(DateTime.Now);

            _nameToDisplay = user.UserName ?? user.Name;                        
        }
    }
}