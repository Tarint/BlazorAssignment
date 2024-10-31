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
                    _userDatas = GetUserDatasList();
                }
                return _userDatas;
            }
        }

        public UserDataAccess()
        {
            
        }

        private List<UserData> GetUserDatasList()
        {
            List<UserData> listOfUsers = new List<UserData>
            {
                new UserData(2, "Max Verstappen", "IamNumber1", "max.verstappen@gmail.com", 1763078985, "Vasagatan", "Stockholm", 11522, "Google", "Dont be Evil"),
                new UserData(1, "Lewis Hamilton", "IamSpeed", "lewis.hamilton@gmail.com", 5569132080, "Kungsgatan", "Uppsala", 11140, "Apple", "Think Diffirent"),
                new UserData(8, "Markus Pärson", "BlockMan", "markus.person@gmail.com", 7636758362, "Stationsgatan", "Malmö", 21143, "Mojang", "Endless possibilities"),
                new UserData(4, "Zara Larsson", "Zara", "zara.larsson@gmail.com", 9608411182, "Stefansgatan", "Stockholm", 70374, "Microsoft", "Embrace, extend, and extinguish"),
                new UserData(3, "Sanna Marin", "FinnishLeader", "sanna.marin@gmail.com", 7053629083, "Markgatan", "Borås", 74636, "Nvidia", "Graphics Reinvented"),
                new UserData(10, "Johan Lundgren", "GhostMariner", "johan.lundgren@gmail.com", 7546463303, "Apelvägen", "Uppsala", 17930, "Amazon", "From A to Z"),
                new UserData(6, "Kira Carsen", "JediNr1", "kira.carsen@gmail.com", 6036172063, "Friisgatan", "Stockholm", 60374, "ASUS", "In Search of Incredible"),
                new UserData(7, "Lana Beniko", "Nr1Sith", "lana.beniko@gmail.com", 6036172083, "Friisgatan", "Stockholm", 60374, "ASUS", "In Search of Incredible"),
                new UserData(5, "Alexander Bard", "Charisma100", "alexander.bard@gmail.com", 8133057589, "Marieholmsvägen", "Borås", 52907, "Honda", "Technology you can enjoy"),
                new UserData(9, "Thomas Lövgren", "Canadianian", "thomas.lovgren@gmail.com", 8979385949, "Stationsvägen", "Uppsala", 11397, "Tropicana", "Tropicana. Straight from the Fruit")
            };

            return listOfUsers;
        }
    }
}
