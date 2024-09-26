using SocialMedia.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMedia.DAL.Repo.Abstraction
{
    public interface IUserRepo
    {
        List<User> GetUsers();
        User GetUserById(int id);
        bool Create(User user);
        bool Update(User user);
        bool Delete(int id);

    }
}
