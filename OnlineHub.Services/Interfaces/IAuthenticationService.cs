using OnlineHub.Entities;

namespace OnlineHub.Services.Interfaces
{
    public interface IAuthenticationService
    {
        bool CreateUser(User user, string password);
        Task<bool> SignOut();
        User AuthenticateUser(string username, string password);
        User GetUser(string username);
    }
}
