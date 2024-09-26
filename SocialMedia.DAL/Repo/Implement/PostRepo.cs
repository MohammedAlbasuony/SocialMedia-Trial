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
    public class PostRepo : IPostRepo
    {
        ApplicationDbContext Db = new ApplicationDbContext();
        public bool Create(Post post)
        {
            try
            {
                Db.Posts.Add(post);
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
                var Result = Db.Posts.Where(u => u.ID == id).FirstOrDefault();
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

        public Post GetPostById(int id) => Db.Posts.Where(u => u.ID == id).FirstOrDefault();

        public List<Post> GetPosts() => Db.Posts.Where(u => u.IsDeleted != true).ToList();


        public bool Update(Post post)
        {
            try
            {
                var Result = Db.Posts.Where(u => u.ID == post.ID).FirstOrDefault();
                if (Result != null)
                {
                    Result.Title = post.Title;
                    Result.Description = post.Description;
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
