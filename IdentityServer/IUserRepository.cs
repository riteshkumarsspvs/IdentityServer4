using System.Threading.Tasks;

namespace IdentityServer
{
    public interface IUserRepository
    {
        Task<dynamic> FindByName(string name);
        Task<dynamic> FindById(long userId);
    }
}
