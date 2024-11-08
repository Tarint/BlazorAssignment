using BlazorAssignment.Components.Pages;
using System.IO;
using System.Reflection.Emit;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

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
                    _userDatas = GetUserDatas();
                }
                return _userDatas;
            }
        }

        public UserDataAccess()
        {
            
        }

        private List<UserData> GetUserDatas()
        {
            List<UserData> listOfUsers = new List<UserData>
            {
                new UserData(2, "Max Verstappen", "IamNumber1", "max.verstappen@gmail.com", "1763078985", new Address("Vasagatan", "Stockholm", "11522"), new Company("Google", "Dont be Evil")),
                new UserData(1, "Lewis Hamilton", "IamSpeed", "lewis.hamilton@gmail.com", "5569132080",new Address("Kungsgatan", "Uppsala", "11140"), new Company("Apple", "Think Diffirent")),
                new UserData(8, "Markus Pärson", "Notch", "markus.person@gmail.com", "7636758362", new Address("Stationsgatan", "Malmö", "21143"), new Company("Mojang", "Endless possibilities")),
                new UserData(4, "Zara Larsson", "Zara", "zara.larsson@gmail.com", "9608411182", new Address("Stefansgatan", "Stockholm", "70374"), new Company("Microsoft", "Embrace, extend, and extinguish")),
                new UserData(3, "Sanna Marin", "FinnishLeader", "sanna.marin@gmail.com", "7053629083", new Address("Markgatan", "Borås", "74636"), new Company("Nvidia", "Graphics Reinvented")),
                new UserData(10, "Johan Lundgren", "GhostMariner", "johan.lundgren@gmail.com", "7546463303", new Address("Apelvägen", "Uppsala", "17930"), new Company("Amazon", "From A to Z")),
                new UserData(6, "Kira Carsen", "JediNr1", "kira.carsen@gmail.com", "6036172063", new Address("Friisgatan", "Stockholm", "60374"), new Company("ASUS", "In Search of Incredible")),
                new UserData(7, "Lana Beniko", "Nr1Sith", "lana.beniko@gmail.com", "6036172083", new Address("Friisgatan", "Stockholm", "60374"), new Company("ASUS", "In Search of Incredible")),
                new UserData(5, "Alexander Bard", "Charisma100", "alexander.bard@gmail.com", "8133057589", new Address("Marieholmsvägen", "Borås", "52907"), new Company("Honda", "Technology you can enjoy")),
                new UserData(9, "Thomas Lövgren", "Canadianian", "thomas.lovgren@gmail.com", "8979385949", new Address("Stationsvägen", "Uppsala", "11397"), new Company("Tropicana", "Tropicana. Straight from the Fruit"))
            };

            return listOfUsers;
        }
    }
}
