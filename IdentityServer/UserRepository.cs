using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityServer
{
    public class UserRepository : IUserRepository
    {
        public List<dynamic> Users { get; set; } = new List<dynamic> {
            new {
                UserName="ritesh",
                UserId=123,
                Password="test",
                Lastname="Kumar",
                Firstname="Ritesh",
                FamilyName="",
                Email="test@test.com",
                Some_Data_From_User="Some_Data_From_User",
                Role="admin",
                IsActive=true,
            }
        };

        public async Task<dynamic> FindById(long userId)
        {
            return await Task.Run(() =>
            {
                return Users.FirstOrDefault(m => m.UserId == userId);
            });
        }

        public async Task<dynamic> FindByName(string name)
        {
            return await Task.Run(() =>
            {
                return Users.FirstOrDefault(m => m.UserName == name);
            });
        }

    }
}
