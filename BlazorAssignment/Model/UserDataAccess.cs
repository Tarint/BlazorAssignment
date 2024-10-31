using BlazorAssignment.Components.Pages;

namespace BlazorAssignment.Model
{
    public interface IUserDataAccsess
    {
        List<UserData> UserDatas { get; }
    }

    /*public class APIUserDataAccess : IUserDataAccsess
    {

    }*/
    public class UserDataAccess : IUserDataAccsess
    {
        private List<UserData> _userDatas;
        public List<UserData> UserDatas { 
            get 
            { 
                if(_userDatas == null)
                {
                    _userDatas = GetUserDatasList();
                }
                return _userDatas;
            }
        }

        private readonly int[] _id = new[]
            { 7, 2, 9, 10, 3, 5, 1, 8, 4, 6 };

        private readonly string[] _name = new[] 
            { "Max Verstappen", "Lewis Hamilton", "Markus Pärson", "Zara Larson", "Sanna Marin", "Johan Lundgren", "Kira Carsen", "Lana Beniko", "Alexander Bard", "Thomas Lövgren" };
        private readonly string[] _userName = new[]
            { "RandomUser1", "RandomUser2", "RandomUser3", "RandomUser19", "RandomUser9", "RandomUser5", "RandomUser16", "RandomUser7", "RandomUser12", "RandomUser20" };
        private readonly string[] _email = new[]
            { "RandomUser1", "RandomUser2", "RandomUser3", "RandomUser19", "RandomUser9", "RandomUser5", "RandomUser16", "RandomUser7", "RandomUser12", "RandomUser20" };
        private readonly long[] _phoneNumber = new[]
            { 1763078985, 5569132080, 7636758362, 9608411182, 7053629083, 7546463303, 6036172063, 6394588951, 8133057589, 8979385949 };

        private readonly string[] _street = new[]
            { "Vasagatan", "Kungsgatan", "Stationsgatan", "Stefansgatan", "Markgatan", "Apelvägen", "Marieholmsvägen", "Friisgatan" };
        private readonly string[] _city = new[]
            { "Stockholm", "Malmö", "Uppsala", "Örebro" };
        private readonly int[] _zipCode = new[]
            { 11522, 11140, 21143, 70374, 74636 };


        private readonly string[] _companyName = new[]
            { "Sten", "RandomUser2", "RandomUser3", "RandomUser19", "RandomUser9", "RandomUser5", "RandomUser16", "RandomUser7", "RandomUser12", "RandomUser20" };
        private readonly string[] _companyCatchphrase = new[]
            { "Dont be Evil", "Jobba Hårt", "Familjen Betyder Allt", "Vi har Låga Priser" };

        public UserDataAccess()
        {
            
        }

        private List<UserData> GetUserDatasList()
        {
            return Enumerable.Range(0, 10).Select(index => new UserData
            {
                ID = _id[Random.Shared.Next(_id.Length)],

                Name = _name[Random.Shared.Next(_name.Length)],
                UserName = _userName[Random.Shared.Next(_userName.Length)],
                Email = _email[Random.Shared.Next(_email.Length)],
                PhoneNumber = _phoneNumber[Random.Shared.Next(_phoneNumber.Length)],

                Street = _street[Random.Shared.Next(_street.Length)],
                City = _email[Random.Shared.Next(_email.Length)],
                Zipcode = _zipCode[Random.Shared.Next(_zipCode.Length)],

                CompanyName = _email[Random.Shared.Next(_email.Length)],
                CompanyCatchphrase = _email[Random.Shared.Next(_email.Length)],

            }).ToList();
        }
    }
}
