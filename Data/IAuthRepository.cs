using System.Threading.Tasks;
using dotnet_rpg.Models;

namespace dotnet_rpg.Data
{
    public interface IAuthRepository
    {
        //returns the id of the user
         Task<ServiceResponse<int>> Register (User user, string password);
         //return a token as string
         Task<ServiceResponse<string>> Login (string userName, string password);
         //check if user already exists
         Task<bool> UserExists(string userName);
    }
}