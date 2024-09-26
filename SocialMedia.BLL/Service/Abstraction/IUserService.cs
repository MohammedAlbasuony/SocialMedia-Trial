using SocialMedia.BLL.ModelVM;
using SocialMedia.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMedia.BLL.Service.Abstraction
{
    public interface IUserService
    {
        List<GetAllUserVM> GetUsers();
        User GetUserById(int id);
        bool Create(CreateUserVM user);
        bool Update(UpdateUserVM user);
        bool Delete(int id);

    }
}
