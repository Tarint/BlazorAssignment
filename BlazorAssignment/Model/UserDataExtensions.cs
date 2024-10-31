using BlazorAssignment.Components.Pages;
using System.Net.Security;

namespace BlazorAssignment.Model
{
    public static class UserDataExtensions
    {
        public static List<UserData> GetUserDatas(this IEnumerable<UserData> userDatas)
        {
            return userDatas.ToList();
        }
        public static List<UserData> GetFilteredUserData(this IEnumerable<UserData> userDatas, int startIndex, int count)
        {
            if (startIndex < 0 || startIndex >= userDatas.Count())
            {
                throw new ArgumentOutOfRangeException(nameof(startIndex));
            }
            if(count < 0 || startIndex + count > userDatas.Count())
            {
                throw new ArgumentOutOfRangeException(nameof(count));
            }

            if(startIndex == 0)
            {
                return userDatas.Take(count).ToList();
            }
            else
            {
                return userDatas.Skip(startIndex).Take(count).ToList();
            }
        }
        public static List<UserData> GetUserDataOrderByName(this IEnumerable<UserData> userDatas)
        {
            return userDatas.OrderBy(x => x.Name).ToList();
        }
        public static List<UserData> GetUserDataOrderByID(this IEnumerable<UserData> userDatas)
        {
            return userDatas.OrderBy(x => x.ID).ToList();
        }

        /*, int startIndex, int count*/
    }
}
