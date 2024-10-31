using BlazorAssignment.Model;
using Microsoft.AspNetCore.Components;

namespace BlazorAssignment.Components.Pages
{
    public partial class Users
    {
        private List<UserData>? _users;

        private List<UserData>? _filteredUsers;

        private bool changeButton = true;
        private bool longShort = true;

        [Parameter]
        public string Heading { get; set; }
        [Parameter]
        public int AmountOfUsers { get; set; }
        [Parameter]
        public IUserDataAccsess DataAccess {  get; set; }

        protected override async Task OnInitializedAsync()
        {
            await Task.Delay(500);

            Heading ??= "Users from UserDataAccess";
            DataAccess ??= new UserDataAccess();

            if (AmountOfUsers < 1)
            {
                AmountOfUsers = 5;
            }

            DisplayInitialUsers();
        }

        private void DisplayAllUsers()
        {
            _users = DataAccess.UserDatas.GetUserDatas();
            longShort = false;
            changeButton = false;
            StateHasChanged();
        }
        private void DisplaySomeUsers()
        {
            _users = DataAccess.UserDatas.GetFilteredUserData(0, AmountOfUsers);
            longShort = true;
            changeButton = true;
            StateHasChanged();
        }

        private void OrderByNameShortList()
        {
            _users = DataAccess.UserDatas.GetFilteredUserData(0, AmountOfUsers).GetUserDataOrderByName();
        }
        private void OrderByIDShortList()
        {
            _users = DataAccess.UserDatas.GetFilteredUserData(0, AmountOfUsers).GetUserDataOrderByID();
        }

        private void OrderByNameLongList()
        {
            _users = DataAccess.UserDatas.GetUserDataOrderByName();
        }
        private void OrderByIDLongList()
        {
            _users = DataAccess.UserDatas.GetUserDataOrderByID();
        }

        private void DisplayInitialUsers()
        {
            _users = DataAccess.UserDatas.GetFilteredUserData(0, AmountOfUsers).GetUserDataOrderByName();
        }
    }
}