using SocialMedia.BLL.ModelVM;
using SocialMedia.BLL.Service.Abstraction;
using SocialMedia.DAL.Entities;
using SocialMedia.DAL.Repo.Abstraction;
using SocialMedia.DAL.Repo.Implement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMedia.BLL.Service.Implement
{
    public class UserService : IUserService
    {
        IUserRepo Service = new UserRepo();
        public bool Create(CreateUserVM user)
        {
            try
            {
                User use = new User()
                {
                    Name = user.Name,
                    Age = user.Age ,
                    Email = user.Email ,
                    Password = user.Password ,
                };

                return Service.Create(use);
            }
            catch (Exception)
            {

                return false;
            }

        }

        public bool Delete(int id)
        {

            try
            {
                return Service.Delete(id);
            }
            catch (Exception)
            {

                return false;
            }
        }

        public User GetUserById(int id) => Service.GetUserById(id);

        public List<GetAllUserVM> GetUsers()
        {
            List<GetAllUserVM> getAllUserVMs = new List<GetAllUserVM>();
            var result = Service.GetUsers();
            foreach (var item in result)
            {
                getAllUserVMs.Add(new GetAllUserVM()
                {
                    ID = item.ID,
                    Name = item.Name,
                    Age = item.Age,
                    CreatedOn = item.CreatedOn
                });

            }

            return getAllUserVMs;
        }

        public bool Update(UpdateUserVM user)
        {
            try
            {
                User use = new User()
                {
                    Name = user.Name,
                    Age = user.Age,
                    Email = user.Email,
                    Password = user.Password,
                };
                return Service.Update(use);

                return false;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
