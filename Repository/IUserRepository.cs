using WebApplication1.Models;

namespace WebApplication1.Repository
{
    public interface IUserRepository
    {
        User GetUserByEmailOrUserName(string emailOrUserName);
    }
}
