using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeleHealth_API.Models;
using TeleHealth_API.Helpers;

namespace TeleHealth_API.Services
{
    /*
        User Service

        Description: Contains the function pertaining to user authentication.
                     The Authenticate function will compare the username and password
                     provided against a list of existing users and will return null if
                     the user does not exist else it will return the discovered user.
    */
    public interface IUserService
    {
        Task<User> Authenticate(string username, string password);
    }

    public class UserService : IUserService
    {
        // These users are hardcoded for simplicity. 
        // In an actual deployment this would be replaced by a function that would get the users from the API.
        private List<User> _users = new List<User>
        {
            new User { ID = 1, userName = "admin", password = "admin", role = "admin" },
            new User { ID = 2, userName = "John", password = "Doe", role = "employee" }
        };

        public async Task<User> Authenticate(string username, string password)
        {
            var user = await Task.Run(() => _users.SingleOrDefault(x => x.userName == username && x.password == password));

            // Return null if user is not found.
            if (user == null)
                return null;

            // Authentication was successful so return user details. The password is phased out by the appropriate DTO.
            return user;
        }
    }
}