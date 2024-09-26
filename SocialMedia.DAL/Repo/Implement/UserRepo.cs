using SocialMedia.DAL.DB;
using SocialMedia.DAL.Entities;
using SocialMedia.DAL.Repo.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMedia.DAL.Repo.Implement
{
    public class UserRepo : IUserRepo
    {
        ApplicationDbContext Db = new ApplicationDbContext();
        public bool Create(User user)
        {
            try
            {
                Db.Users.Add(user);
                Db.SaveChanges();
                return true;
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
                var Result = Db.Users.Where(u => u.ID == id).FirstOrDefault();
                if (Result != null)
                {
                    Result.IsDeleted = !Result.IsDeleted;
                    Db.SaveChanges();
                    return true;
                }
                return false;
            }
            catch (Exception)
            {

                return false;
            }    
        }

        public User GetUserById(int id)  => Db.Users.Where(u => u.ID == id).FirstOrDefault();

        public List<User> GetUsers() => Db.Users.Where(u => u.IsDeleted != true).ToList();


        public bool Update(User user)
        {
            try
            {
                var Result = Db.Users.Where(u => u.ID == user.ID).FirstOrDefault();
                if (Result != null)
                {
                    Result.Name = user.Name;
                    Result.Email = user.Email;
                    Result.Password = user.Password;
                    Result.Age = user.Age;

                    Db.SaveChanges();
                    return true;
                }
                return false;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
