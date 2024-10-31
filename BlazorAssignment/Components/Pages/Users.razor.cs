using BlazorAssignment.Model;
using Microsoft.AspNetCore.Components;

namespace BlazorAssignment.Components.Pages
{
    public partial class Users
    {
        private List<UserData>? _users;

        [Parameter]
        public string Heading { get; set; }
        [Parameter]
        public int AmountOfUsers { get; set; }
        [Parameter]
        public IUserDataAccsess DataAccess {  get; set; }

        protected override async Task OnInitializedAsync()
        {
            // Simulate asynchronous loading to demonstrate streaming rendering
            await Task.Delay(500);

            Heading ??= "Users from UserDataAccess";
            DataAccess ??= new UserDataAccess();

            if (AmountOfUsers < 1)
            {
                AmountOfUsers = 5;
            }

            DisplaySomeUsers();
            
        }
        
        private void DisplayAllUsers()
        {
            _users = DataAccess.UserDatas.GetUserDatas();
        }
        private void DisplaySomeUsers()
        {
            _users = DataAccess.UserDatas.GetFilteredUserData(0, AmountOfUsers);
        }

        private void OrderByName()
        {
            _users = DataAccess.UserDatas.GetUserDataOrderByName();
        }
        private void OrderByID()
        {
            _users = DataAccess.UserDatas.GetUserDataOrderByID();
        }
    }
}